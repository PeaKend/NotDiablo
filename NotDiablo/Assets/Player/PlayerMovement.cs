using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body; Animator anim;
	float movementSpeed = 100;
	public GameObject aimPrefab; GameObject aim;
	Vector3 cameraOffset;

	void Awake() {
		DontDestroyOnLoad(gameObject);	
	}
	void Start () {
		body = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		cameraOffset = Camera.main.transform.position - transform.position;
		Cursor.visible = false;
		aim = Instantiate(aimPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		body.velocity = Vector2.zero;
		if ( playerisMoving() )
		{
			moveCharacter();
		}
		Camera.main.transform.position = transform.position + cameraOffset;
		Vector2 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		aim.transform.position = new Vector3(point.x, point.y, aim.transform.position.z);
	}

	bool playerisMoving() {
		if ( (Mathf.Abs(Input.GetAxis("Horizontal")) > 0) || (Mathf.Abs(Input.GetAxis("Vertical")) > 0) )
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	void moveCharacter() {
		body.AddForce( Vector2.up * Input.GetAxisRaw("Vertical") * movementSpeed);
		body.AddForce( Vector2.right * Input.GetAxisRaw("Horizontal") * movementSpeed);
	}
}
