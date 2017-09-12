using UnityEngine;
using System.Collections;

public class zmianasceny : MonoBehaviour {
	public GameObject znaczek;
	void Start(){
		if (Application.loadedLevel == 0) {
			znaczek.SetActive (false);
			//GameObject.Find("znaczek").SetActive(false);
		} else {
			znaczek.SetActive (true);
			//GameObject.Find("znaczek").SetActive(true);
		}
	}
	void OnGUI()
	{
		GUILayout.BeginArea (new Rect (0,160,78,60));
		if (Application.loadedLevel == 0) {
			if (GUILayout.Button ("2")) {
				Application.LoadLevel (1);
			}}
		if (Application.loadedLevel == 1) {
			if (GUILayout.Button ("1")) {
				Application.LoadLevel (0);
			}}
		GUILayout.EndArea();
		GUILayout.BeginArea (new Rect (122,160,78,60));
		if (GUILayout.Button ("Quit")) {
			Application.Quit();
		}
		GUILayout.EndArea();
}
}