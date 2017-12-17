using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	int hp;

	void Awake() 
	{
		hp = setEnemyHp();	
	}

	void Update() 
	{
		// check the amount of hp and die if it is below zero
		if ( hpbelowZero() ) {
			die();
		}
	}

	// set the amount of hp to begin with, optional argument value is for debug only
	int setEnemyHp( int hp = 200 ) 
	{
		return hp;
	}

	// loses hp if attacked, optional value is to prevent bugs
	public void loseHp ( int attackDamage ) 
	{
		hp -= attackDamage;
	}

	// check if hp is below zero
	bool hpbelowZero() 
	{
		if ( hp <= 0 )
			return true;
		else
			return false;
	}

	// die method
	void die() 
	{
		Debug.Log("im dead :'c");
	}
}
 