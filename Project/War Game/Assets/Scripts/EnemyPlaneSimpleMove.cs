using UnityEngine;
using System.Collections;

public class EnemyPlaneSimpleMove : MonoBehaviour {

	private float end = -400;
	public float speed = 100;
	public GameObject explosion;

	public int life;

	private bool pause;

	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(life <= 0){
			Destroy();
			return;
		}

		float current_position = this.transform.position.x;
		current_position += speed * Time.deltaTime;

		this.transform.position = new Vector3 (transform.position.x - speed * Time.deltaTime,
		                                       this.transform.position.y, 
		                                       this.transform.position.z);

		//if (current_position < end)	Destroy(this.gameObject);

	}

	public void Destroy(){
		GameObject player = GameObject.Find ("PlayerPlane");
		PlayerPlane pl = (PlayerPlane) player.GetComponent (typeof(PlayerPlane));
		pl.UpdateMission ();

		Explode explode = (Explode) explosion.GetComponent (typeof(Explode));
		explode.Blow ();
		//Instantiate (explosion, this.transform.position, explosion.transform.rotation);

		Destroy (this.gameObject);
	}


	void OnCollisionEnter(Collision collision) {
		//Debug.Log (collision.gameObject.name.ToString()+" asd");
		if (collision.gameObject.name.Equals("PlayerPlane")) {
			Destroy();
			return;
		}

		if (collision.gameObject.tag.Equals ("Bomb")) {
			Destroy();
			return;
		}


		if (collision.gameObject.tag.Equals ("Rocket")) {
			life -= 2;
			return;
		}
		if (collision.gameObject.tag.Equals ("Bullet")) {
			life -= 1;
			return;
		}
	}
}
