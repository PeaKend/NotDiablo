using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeClass : MonoBehaviour {

	// Use this for initialization
	public GameObject attack;
	int attackCooldown = 60, attackCurrentCooldown = 0;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(attackCurrentCooldown > 0) attackCurrentCooldown--;
		if(attackCurrentCooldown == 0 && Input.GetButton("Fire1"))
		{
			Attack();
			attackCurrentCooldown = attackCooldown;
		}
	}
	void Attack()
	{
		Vector2 dir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
		Quaternion rot = Quaternion.FromToRotation(new Vector2(-1,1), dir);
		//Quaternion rot = Quaternion.identity;//Quaternion.LookRotation(dir);
		Instantiate(attack, transform.position, rot);
	}
}
