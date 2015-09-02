using UnityEngine;
using System.Collections;

public class BombMove : MonoBehaviour {

	public float speed = 120;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		float current_position = this.transform.position.y;
		current_position += speed * Time.deltaTime;
		
		this.transform.position = new Vector3 (transform.position.x ,
		                                       this.transform.position.y - speed * Time.deltaTime, 
		                                       this.transform.position.z);
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag.Equals("Enemy")){
			Destroy(this.gameObject);
		}

		if(collision.gameObject.tag.Equals("SAM")){
			Destroy(this.gameObject);
		}
		
	}
}
