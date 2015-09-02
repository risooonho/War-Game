using UnityEngine;
using System.Collections;

public class BackgroundPlanes : MonoBehaviour {


	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	public GameObject obj5;
	private float timer;

	private bool pause;
	
	void Start () {
		pause = false;
		timer = Random.Range (10, 23);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		timer -= Time.deltaTime;
		if (timer <= 0) {

			float ran = Random.value;

//			Debug.Log(ran);

			GameObject plane;
			if (ran < 0.2) plane = obj1;
			else if(ran < 0.4) plane = obj2;
			else if (ran < 0.6) plane = obj3;
			else if (ran < 0.8) plane = obj4;
			else plane = obj5;

			

			Instantiate(plane,this.transform.position,this.transform.rotation);
			timer = Random.Range (10, 23);
		}
	}
}
