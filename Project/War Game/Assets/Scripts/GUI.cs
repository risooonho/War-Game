using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	void OnGUI(){




		GUILayout.BeginArea(new Rect(2*Screen.width/3,Screen.height/3,200,Screen.height/2));
		GUILayout.Space (15);

		GUILayout.BeginHorizontal ();
		GUILayout.Button ("Story Mode");
		GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		GUILayout.Button ("How to play");
		GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		GUILayout.Button ("Quit");
		GUILayout.EndHorizontal ();

		GUILayout.EndArea();
	}
}
