using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeClass : MonoBehaviour {

	public GameObject attack;
	public int MeleeDamage;
	int attackCooldown = 60, attackCurrentCooldown = 0;

	void Update () 
	{
		// terrible way of implementing this #FIXME
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
		Vector2 dir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
		Quaternion rot = Quaternion.FromToRotation(new Vector2(-1,1), dir);
		//Quaternion rot = Quaternion.identity;//Quaternion.LookRotation(dir);
		Instantiate(attack, transform.position, rot);
	}

	// return damage value based on a base warrior class (strenght > all)
	void setDamage() 
	{
		int playerStrenght = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Controller>().playerStrenght;
		int damageMultiplier = 5;
		MeleeDamage = playerStrenght * damageMultiplier;
	}
}
