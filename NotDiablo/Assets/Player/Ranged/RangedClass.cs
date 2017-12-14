using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedClass : MonoBehaviour {

	// Use this for initialization
	public GameObject projectile;
	int attackCooldown = 30, attackCurrentCooldown = 0;
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
		GameObject g = Instantiate(projectile, transform.position, Quaternion.identity);
		Projectile proj = g.GetComponent<Projectile>();
		proj.speed = .25f;
		proj.target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}
}
