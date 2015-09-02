using UnityEngine;
using System.Collections;

public class EnemyShotMissile : MonoBehaviour {

	public Vector3 target { get; set; }
	public float speed = 20f;

	void Start () {
		
	}
	
	void Update () {
		if(target == null) return;
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, step);
		
		if(this.transform.position.Equals(target)) Destroy(gameObject);
	}
	
	public void OnCollisionEnter(Collision obj){
		Destroy (gameObject);
	}
}
