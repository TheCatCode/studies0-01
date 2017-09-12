using UnityEngine;
using System.Collections;

public class Cameramode : MonoBehaviour {
	private string off = "to use camera mode press space button";
	private string on = "to disable camera mode press space button";
	private string current = "to use camera mode press space button";
	public GameObject znaczek;

	void LateUpdate() 
	{
		if (Input.GetKeyDown ("space")) 
		{
			if (current == on)
			{current = off;
				znaczek.SetActive(true);
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				GameObject.Find("Main Camera").GetComponent<MouseOrbit>().SendMessage("cam" , false);
			
			}
		else
		 	{current = on;
				znaczek.SetActive(false);
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				GameObject.Find("Main Camera").GetComponent<MouseOrbit>().SendMessage("cam" , true);
			}
		}
	}
	void OnGUI()
	{
		GUI.Box(new Rect(0,0,Screen.width,25), current);
	}
}