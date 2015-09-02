using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	private bool seen;

	// Use this for initialization
	void Start () {
		seen = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(renderer.isVisible) seen = true;

		if(seen && !renderer.isVisible)	Destroy(this.gameObject);
	}
}
