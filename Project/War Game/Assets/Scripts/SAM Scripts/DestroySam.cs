using UnityEngine;
using System.Collections;

public class DestroySam : MonoBehaviour {

	// Use this for initialization

	public bool seen;

	void Start () {
		seen = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(renderer.isVisible) seen = true;

		if(!renderer.isVisible && seen) Destroy(this.gameObject);
	}
}
