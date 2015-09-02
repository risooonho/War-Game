using UnityEngine;
using System.Collections;

public class BossCannon : MonoBehaviour {

	public GameObject bullet;
	public float timeBetweenShots = 0.3f;
	public bool turn;
	private float timestamp;

	private bool pause;
	void Start () {
		pause = false;
		timestamp = Time.time + timeBetweenShots;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(Time.time > timestamp){
			if(turn) Instantiate(bullet,this.transform.position,this.gameObject.transform.rotation);
			timestamp = Time.time + timeBetweenShots;
			turn =!turn;
		}
	}
}
