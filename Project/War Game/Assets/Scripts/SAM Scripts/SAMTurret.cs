using UnityEngine;
using System.Collections;

public class SAMTurret : MonoBehaviour {
	
	private float rotationSpeed = 20f;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(!renderer.isVisible) return;

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if(player == null){
			return;
		}

		float x = this.transform.position.x;
		float y = this.transform.position.y;
		float z = this.transform.position.z;
		
		float px = player.transform.position.x;
		float py = player.transform.position.y;
		float pz = player.transform.position.z;
		

		transform.rotation = Quaternion.Slerp(transform.rotation,
		                                        Quaternion.LookRotation(player.transform.position - transform.position), rotationSpeed*Time.deltaTime);


	}

}
