using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour {


	int duration = 30;
	int damage;

	void Awake() {
		// prevents bugs #FIXME
		updatesDamageValue();
	}

	void Update () 
	{
		// updates damage value each frame (this is horrible, it should be modified to update when neccesary)
		updatesDamageValue();

		if(duration > 0) duration--;
		else Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if ( col.gameObject.tag == "Enemy" ) 
		{
			// if enemy found attack him
			attackEnemy(col.gameObject);
			// debug
			Debug.Log( "Enemy hit: " + damage + " hp lost" );
		}
	}

	void updatesDamageValue() 
	{
		damage = GameObject.FindGameObjectWithTag("Player").GetComponent<MeleeClass>().MeleeDamage;
	}

	void attackEnemy( GameObject enemyObject ) 
	{
		enemyObject.GetComponent<Enemy>().loseHp(damage);
	}
}
