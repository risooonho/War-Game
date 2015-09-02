using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {


	public GameObject status;
	public float life;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
		RefreshStatus();
	}
	public void RefreshStatus(){
		status.guiText.text = "Boss Life: " + life;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(life <=0){
			Destroy(this.gameObject);
			Application.LoadLevel ("GameWon");
			return;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag.Equals("Bullet") || collision.gameObject.tag.Equals("Rocket"))
		{
			life --;
			RefreshStatus();
			return;
		}
	}
}
