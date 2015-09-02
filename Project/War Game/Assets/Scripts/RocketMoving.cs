using UnityEngine;
using System.Collections;

public class RocketMoving : MonoBehaviour {


	public float speed;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		this.transform.position = new Vector3 (this.transform.position.x + this.speed * Time.deltaTime,
		                                      this.transform.position.y,
		                                      this.transform.position.z);

	//	if(!renderer.isVisible)Destroy(this.gameObject);
	//	if(this.transform.position.x > 2000) Destroy(this.gameObject);
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag.Equals("Enemy")){
			Destroy(this.gameObject);
		}
		
	}
}
