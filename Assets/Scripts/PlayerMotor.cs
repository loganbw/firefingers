using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
	private CharacterController controller;
	private Vector3 moveVector;
	private float verticalVelocity = 0.0f;
	private float speed = 5.0f;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	// Update is called once per frame

	void Update () {
		moveVector = Vector3.zero;
		//x = left and right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
		//y = up and down
		moveVector.y = verticalVelocity;
		// z = forward and backward
		moveVector.z = speed;

		controller.Move (moveVector * Time.deltaTime);
	}
}