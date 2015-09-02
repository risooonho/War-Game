using UnityEngine;
using System.Collections;

public class SAMFire : MonoBehaviour {

	public GameObject bullet;
	public float timeBetweenShots = 0.3f;
	public int turn;
	private int keep;
	private float timestamp;

	private bool seen;

	private bool pause;

	void Start () {
		pause = false;
		timestamp = Time.time + timeBetweenShots;
		keep = turn;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(!renderer.isVisible) return;
		if(renderer.isVisible) seen = true;

		if(turn != 0 || turn > 0){
			turn --;
			return;
		}
		turn = keep;
		if(Time.time > timestamp){
			timestamp = Time.time + timeBetweenShots;
			Instantiate(bullet,this.transform.position,this.gameObject.transform.rotation);
		}
	}
}
