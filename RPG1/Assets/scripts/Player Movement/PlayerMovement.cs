using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 15.0f;
	public float rotateSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left shift") && Input.GetKey ("w")) {
			moveSpeed = 10.0f;
		} else {
			moveSpeed = 5.0f;
		}
		if (Input.GetKey ("w")) {
			transform.Translate ((Vector3.forward) * moveSpeed * Time.deltaTime);
			Debug.Log ("Pressing w Key");
		}
		if (Input.GetKey ("s")) {
			transform.Translate ((Vector3.back) * moveSpeed * Time.deltaTime);
			Debug.Log ("Pressing s Key");
		}
		if (Input.GetKey ("a")) {
			transform.Rotate(Vector3.down * rotateSpeed);
			//transform.Translate ((Vector3.left) * moveSpeed * Time.deltaTime);
			Debug.Log ("Pressing a Key");
		}
		if (Input.GetKey ("d")) {
			transform.Rotate(Vector3.up * rotateSpeed);
			//transform.Translate ((Vector3.right) * moveSpeed * Time.deltaTime);
			Debug.Log ("Pressing a Key");
		}
		if (Input.GetMouseButton (1)) {
			Debug.Log ("Pressing right mouse button"); // Mouse button 1 = right mouse button
		}
		if (Input.GetMouseButton (0)) {
			Debug.Log ("Pressing left mouse button"); // Mouse button 0 = left mouse button
		}
	
	}
}
