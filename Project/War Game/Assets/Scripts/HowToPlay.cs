using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnMouseDown(){
		GameObject maincamera = GameObject.FindGameObjectWithTag ("MainCamera");
		maincamera.transform.Rotate (0, 180, 0);
	}
}
