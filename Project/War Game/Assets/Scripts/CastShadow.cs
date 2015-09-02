using UnityEngine;
using System.Collections;

public class CastShadow : MonoBehaviour {


	public bool CastShadows;
	public bool RecieveShadows;

	// Use this for initialization
	void Start () {
		this.renderer.castShadows = this.CastShadows;
		this.renderer.receiveShadows = this.RecieveShadows;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
