using UnityEngine;
using System.Collections;

public class BackgroundPlaneMovement : MonoBehaviour {

	public float speed = 100;

	private bool pause;

	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		this.transform.position = new Vector3 (this.transform.position.x + speed * Time.deltaTime,
		                                      this.transform.position.y,
		                                      this.transform.position.z);

		//if(transform.position.x > 2000) Destroy(this.gameObject);
	}
}
