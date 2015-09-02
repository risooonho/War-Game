using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public Vector3 target { get; set; }
	float speed = 10f;

	void Start () {
	
	}

	void Update () {
		if(target == null) return;
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);

		if(this.transform.position.Equals(target)) SelfDistruction ();
	}

	public void SelfDistruction(){
		Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		SelfDistruction ();
	}
	public void OnCollisionEnter(Collision obj){
		SelfDistruction ();
	}
}
