using UnityEngine;
using System.Collections;
public class MouseOrbit : MonoBehaviour 
    {
		public bool cameramode = false;
        public Transform target;
        public float distance = 10.0f;
        public float xSpeed = 120.0f;
        public float ySpeed = 120.0f;
        public float yMinLimit = -20;
        public float yMaxLimit = 80;
        private float x = 0.0f;
        private float y = 0.0f;
 		void cam(bool x){cameramode = x;}
        void Start () 
        {
            var angles = transform.eulerAngles;
            x = angles.y;
            y = angles.x;
            if (GetComponent<Rigidbody>()) 
                GetComponent<Rigidbody>().freezeRotation = true;
        }
	void LateUpdate ()
    {

	if (cameramode == true) {
		if (target) {
		x += Input.GetAxis ("Mouse X") * xSpeed * Time.deltaTime;
		y -= Input.GetAxis ("Mouse Y") * ySpeed * Time.deltaTime;
		y = ClampAngle (y, yMinLimit, yMaxLimit);
 		transform.rotation = Quaternion.Euler (y, x, 0);
		transform.position = (Quaternion.Euler (y, x, 0)) * new Vector3 (0.0f, 0.0f, -distance) + target.position;
		}
		if (distance < 150 && Input.GetAxis ("Mouse ScrollWheel") < 0) {
				distance = distance + 3;
		}
		if (distance > 30 && Input.GetAxis ("Mouse ScrollWheel") > 0) {
				distance = distance - 3;
		}
	}
	}
    static float ClampAngle(float angle, float min, float max) 
    {
    if (angle < -360){
        angle += 360;
    }
    if (angle > 360){
        angle -= 360;
        }
    return Mathf.Clamp(angle, min, max);
    }
}