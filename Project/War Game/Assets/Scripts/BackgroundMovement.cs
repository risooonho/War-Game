using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour {

	public float moveX;

	private bool pause;

	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;

		if(pause) return;

		float position_x = this.transform.position.x;
		if (position_x <= -1487.3094) {
			this.transform.position = new Vector3 (
				2510f, 
				this.transform.position.y,
				this.transform.position.z);

			return ;
		}

		this.transform.position = new Vector3 (
									transform.position.x - moveX * Time.deltaTime, 
									this.transform.position.y,
									this.transform.position.z);

	}
}
