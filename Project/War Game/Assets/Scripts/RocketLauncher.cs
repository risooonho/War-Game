﻿using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour {

	public GameObject Weapon;
	public bool turn;

	private bool pause;
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;


		if(Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Space)) fire();

	}
	public void fire(){
		if(turn){
			Instantiate(Weapon,this.transform.position,Weapon.transform.rotation);
		}
		
		turn = !turn;
	}
}