using UnityEngine;
using System.Collections;

public class SpawnPlanes : MonoBehaviour {

	
	private float DeltaTime;
	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;

	private bool pause;

	void Start () {
		pause = false;
		DeltaTime = Random.Range(5,10);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		DeltaTime -= Time.deltaTime;
		if(DeltaTime <= 0){

			GameObject enemy = null;

			float r = Random.value;
			if(r < 0.25) enemy = obj1;
			else if(r < 0.5) enemy = obj2;
			else if(r < 0.75) enemy = obj3;
			else  enemy = obj4;

			Instantiate (enemy, this.transform.position, enemy.transform.rotation);
			DeltaTime = Random.Range(5,10);
		}
	}
}
