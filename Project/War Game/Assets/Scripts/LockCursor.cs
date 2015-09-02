using UnityEngine;
using System.Collections;

public class LockCursor : MonoBehaviour {


	public bool locked;

	// Use this for initialization
	void Start () {
		Screen.lockCursor = locked;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
