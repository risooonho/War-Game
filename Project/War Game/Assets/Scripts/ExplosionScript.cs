using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {


	public Texture [] texture;
	private int framesPerSecond = 17;
	private bool destroy;

	private bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)) pause = !pause;
		
		if(pause) return;

		if(destroy) Destroy(this.gameObject);
		float x = (Time.time * framesPerSecond)% texture.Length;

		int index = (int)x;
		renderer.material.mainTexture = texture [index];
		if (index == 16) destroy = true;
	}
}
