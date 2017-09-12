using UnityEngine;
using System.Collections;

public class walk : MonoBehaviour {

	private float sliderValue = 1.0f;
	private float maxSliderValue = 5.0f;
	public GameObject avatar1;
	public GameObject avatar2;
	public GameObject kamera;
	
	void OnGUI()
	{
		GUILayout.BeginArea (new Rect (0,80,200,60));
		
		GUILayout.BeginHorizontal();

		if (GUILayout.Button ("animate"))
		{
			string s=(Mathf.Round(sliderValue)).ToString();

			if (kamera.GetComponent<wybraniec>().wybrany == 1){
				avatar1.GetComponent<Animation>().CrossFade("walk"+s);
			}
			if (kamera.GetComponent<wybraniec>().wybrany == 2){
				avatar2.GetComponent<Animation>().CrossFade("walk"+s);
			}
			
		}
	
		GUILayout.BeginVertical();
		GUILayout.Box("walk " + Mathf.Round(sliderValue));
		sliderValue = GUILayout.HorizontalSlider (sliderValue, 1.0f, maxSliderValue);
	
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
