using UnityEngine;
using System.Collections;

public class Idle : MonoBehaviour {
	private float sliderValue = 1.0f;
	private float maxSliderValue = 5.0f;
	public GameObject avatar1;
	public GameObject avatar2;
	public GameObject kamera;
	void OnGUI()
	{
		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0,40,200,60));
		
		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();
		
		// Place a Button normally
		if (GUILayout.Button ("animate"))
		{
			string s=(Mathf.Round(sliderValue)).ToString();
			
			if (kamera.GetComponent<wybraniec>().wybrany == 1){
				avatar1.GetComponent<Animation>().CrossFade("idle"+s);
			}
			if (kamera.GetComponent<wybraniec>().wybrany == 2){
				avatar2.GetComponent<Animation>().CrossFade("idle"+s);
			}
			
			
			
			
		}
		
		// Arrange two more Controls vertically beside the Button
		GUILayout.BeginVertical();
		GUILayout.Box("idle " + Mathf.Round(sliderValue));
		sliderValue = GUILayout.HorizontalSlider (sliderValue, 1.0f, maxSliderValue);
		
		// End the Groups and Area
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

}
