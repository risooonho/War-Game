using UnityEngine;
using System.Collections;

public class BossFight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.T))
			Application.LoadLevel ("GameLevel1");
	}
}
