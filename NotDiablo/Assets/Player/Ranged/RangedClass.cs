using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedClass : MonoBehaviour {

	public GameObject projectile;
	public int RangedDamage;
	int attackCooldown = 30, attackCurrentCooldown = 0;
	
	void Update () {
		// really wrong way of implementing this #FIXME
		setDamage();

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

	// sets damage (agility > all)
	void setDamage() 
	{
		int playerAgility = GameObject.FindGameObjectWithTag("GameController").GetComponent<Controller>().playerAgility;
		int damageMultiplier = 3;
		RangedDamage = playerAgility * damageMultiplier;
	}
}
