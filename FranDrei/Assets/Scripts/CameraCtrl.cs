using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour {
	public float speed;

	public float speedH = 2.0f;
	public float speedV = 2.0f;
	private float yaw = 0.0f;
	private float pitch = 0.0f;
	//public Camera cameraView;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.back * speed * Time.deltaTime);
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			transform.Translate (Vector3.up * (speed*3) * Time.deltaTime);
		}
		yaw += speedH * Input.GetAxis ("Mouse X");
		pitch -= speedV * Input.GetAxis ("Mouse Y");
		transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
	}
}