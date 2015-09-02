using UnityEngine;
using System.Collections;

public class PlayerPlane : MonoBehaviour {


	public float speed;

	private bool forward = false;
	private bool backward = false;
	private bool up = false;
	private bool down = false;

	public GameObject plane;

	public GameObject health;
	public GameObject mission;
	private int destroyed;


	public float max_x = 709.6f;
	public float min_x = -31.69f;
	
	public float max_y = 147f;
	public float min_y = -283f;


	public void UpdateMission(){
		destroyed ++;
		mission.guiText.text = "Planes Destroyed: "+destroyed;
		if(destroyed>=50)
			Application.LoadLevel ("LoadingScreen");
	}


	public float life;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
		destroyed = 0;
		mission.guiText.text = "Planes Destroyed: "+destroyed;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		Directions ();
		Movement ();
		Rotation ();
		if(life<=0.1f) {
			Destroy(this.gameObject);
			Application.LoadLevel ("GameOver");
			return;
		}
	}

	public void Directions(){
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) up = true;
		else up = false;

		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) down = true;
		else down = false;

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) backward = true;
		else backward = false;

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) forward = true;
		else forward = false ;

	}

	public void Movement(){
		if (forward){
			
			float next_step = this.transform.position.x + this.speed*Time.deltaTime;
			if(next_step<max_x)
				this.transform.position = new Vector3 (this.transform.position.x + this.speed * Time.deltaTime,
				                                       this.transform.position.y,
				                                       this.transform.position.z);
		}
		if (backward){
			float next_step = this.transform.position.x - this.speed*Time.deltaTime;
			if(next_step > min_x)
				this.transform.position = new Vector3 (this.transform.position.x - this.speed * Time.deltaTime,
				                                       this.transform.position.y,
				                                       this.transform.position.z);
		}
		if (up){
			float next_step = this.transform.position.y + this.speed * Time.deltaTime;
			if(next_step < max_y)
				this.transform.position = new Vector3 (this.transform.position.x,
				                                       this.transform.position.y + this.speed * Time.deltaTime,
				                                       this.transform.position.z);
		}
		if (down){
			float next_step = this.transform.position.y + this.speed * Time.deltaTime;
			if(next_step > min_y)
				this.transform.position = new Vector3 (this.transform.position.x,
				                                       this.transform.position.y - this.speed * Time.deltaTime,
				                                       this.transform.position.z);
		}
		
	}

	public void Rotation(){
		if(up){
			float current_rotation = this.plane.transform.rotation.eulerAngles.x;


			if((current_rotation >= 0 && current_rotation < 45) ||
			   (current_rotation >= 315 && current_rotation <= 360)){
				float new_rotation = current_rotation + (20 * Time.deltaTime);
				if(new_rotation >= 45) return;

				this.plane.transform.Rotate(new Vector3(20 *Time.deltaTime,0,0));
			}

		
		}

		if (!up) {
			float current_rotation = this.plane.transform.rotation.eulerAngles.x;

			if(current_rotation < 50 && current_rotation > 0){
				float new_rotation = current_rotation + (-20 * Time.deltaTime);
				if(new_rotation < 0) return;
					this.plane.transform.Rotate(new Vector3(-20 *Time.deltaTime,0,0));
			}

		}

		if(down){
			float current_rotation = this.plane.transform.rotation.eulerAngles.x;
			if (current_rotation <=1) current_rotation = 360;
			if((current_rotation <= 1 && current_rotation >=0)||
			   (current_rotation <=360 && current_rotation >315)){
				float new_rotation = current_rotation + (-20 * Time.deltaTime);

				if(new_rotation < 315) return;
				this.plane.transform.Rotate(new Vector3(-20 *Time.deltaTime,0,0));
			}
		}

		if(!down){
			float current_rotation = this.plane.transform.rotation.eulerAngles.x;
			if (current_rotation <=1) current_rotation = 360;

			if(current_rotation >= 315 ){
				float new_rotation = current_rotation + (20 * Time.deltaTime);
				

				this.plane.transform.Rotate(new Vector3(20 *Time.deltaTime,0,0));
			}
		}


	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag.Equals ("SAM")) {
			this.life -= 0.1f;
			health.guiText.text = "Player Life: "+life;
		}

		if (collision.gameObject.tag.Equals ("Enemy")) {
			this.life -= 1;
			health.guiText.text = "Player Life: "+life;
		}

	
	}

}
