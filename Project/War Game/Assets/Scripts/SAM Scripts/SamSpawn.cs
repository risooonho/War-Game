using UnityEngine;
using System.Collections;

public class SamSpawn : MonoBehaviour {

	public GameObject sam;
	public float p;
	public float timeBetweenShots = 2f;
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

		float ran = Random.value;

		if(ran > p && Time.time > timestamp){
			Instantiate(sam,this.transform.position,this.gameObject.transform.rotation);
			timestamp = Time.time + timeBetweenShots;
		}
	}
}
