using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body; Animator anim;
	public GameObject aim;
	float movementSpeed = 100;
	Vector3 cameraOffset;
	public GameObject projectile;
	void Start () {
		body = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		cameraOffset = Camera.main.transform.position - transform.position;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		aim.transform.position = new Vector3(point.x, point.y, aim.transform.position.z);
		body.velocity = Vector2.zero;
		body.AddForce(Vector2.up*Input.GetAxisRaw("Vertical")*movementSpeed);
		body.AddForce(Vector2.right*Input.GetAxisRaw("Horizontal")*movementSpeed);
		Camera.main.transform.position = transform.position + cameraOffset;
		if(Input.GetMouseButtonDown(0))
		{
			GameObject g = Instantiate(projectile, transform.position, Quaternion.identity);
			Projectile proj = g.GetComponent<Projectile>();
			proj.speed = .25f;
			proj.target = aim.transform.position;
		}
	}
}
