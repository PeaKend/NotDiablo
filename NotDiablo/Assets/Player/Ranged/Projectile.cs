using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public Vector2 target;
	public float speed;
	int damage;

	void Awake() {
		// prevents bugs, #FIXME
		updatesDamageValue();	
	}

	void Update () 
	{
		// updates the amount of damage to apply
		updatesDamageValue();


	{
		transform.position = Vector2.MoveTowards(transform.position, target, speed);
		if(transform.position.x == target.x && transform.position.y == target.y) Destroy(gameObject);
	}

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if ( col.gameObject.tag == "Enemy" ) {
			// attack enemy
			attackEnemy(col.gameObject);

			// debug
			Debug.Log("IMMA ENEMY, I LOST " + damage + " HP");
		}
	}

	void updatesDamageValue() 
	{
		damage = GameObject.FindGameObjectWithTag("Player").GetComponent<RangedClass>().RangedDamage;
	}

	void attackEnemy( GameObject enemyObject ) 
	{
		enemyObject.GetComponent<Enemy>().loseHp(damage);
	}
}
