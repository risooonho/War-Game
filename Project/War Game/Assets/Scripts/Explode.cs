using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	public GameObject explosion;

	public void Blow(){
		Instantiate (explosion, this.transform.position, explosion.transform.rotation);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
