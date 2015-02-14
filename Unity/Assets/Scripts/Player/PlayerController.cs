using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float maxHorizontalSpeed = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		float move = Input.GetAxis ("Horizontal");
		print ("Move: " + move.ToString());
		rigidbody2D.AddForce(new Vector2(move*this.maxHorizontalSpeed,rigidbody2D.velocity.y));
	}

}
