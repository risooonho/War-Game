using UnityEngine;
using System.Collections;

public class MainGun : MonoBehaviour {

	public GameObject bullet;
	public float timeBetweenShots = 0.333333f;

	private float timestamp;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
		timestamp = Time.time + timeBetweenShots;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.RightCommand)){
			if(Time.time > timestamp){
				Instantiate(bullet,this.transform.position,this.gameObject.transform.rotation);
				timestamp = Time.time + timeBetweenShots;
			}
		}
	}
		
}
