using UnityEngine;
using System.Collections;

public class kliknij : MonoBehaviour {
	public GameObject kamera;
	public GameObject znaczek;
	void OnMouseDown() {
		if(this.gameObject.name == "classic_avatar_1")
		{kamera.GetComponent<wybraniec> ().wybrany = 1;
			znaczek.transform.position = new Vector3(-20, 80, 0);
		}
		if(this.gameObject.name == "classic_avatar_2")
		{kamera.GetComponent<wybraniec> ().wybrany = 2;
			znaczek.transform.position = new Vector3(20, 80, 0);
		}

		}
}
