using UnityEngine;
using System.Collections;

public class BossBullet : MonoBehaviour {

	public Transform target;
	public float ProjectileSpeed = 90;
	
	private Transform myTransform;

	private bool pause;
	// Use this for initialization
	void Start () {
		myTransform = transform;
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;
		// rotate the projectile to aim the target:
		myTransform.LookAt(target);

		pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		// distance moved since last frame:
		float amtToMove = ProjectileSpeed * Time.deltaTime;
		// translate projectile in its forward direction:
		myTransform.Translate(Vector3.forward * amtToMove);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag.Equals ("Player")) {
			Destroy(this.gameObject);
		}
		
	}
}
