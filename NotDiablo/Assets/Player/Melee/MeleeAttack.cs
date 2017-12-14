using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour {

	// Use this for initialization
	int duration = 30;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(duration > 0) duration--;
		else Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log(col.tag);
		if(col.tag != "Player") Destroy(col.gameObject);
	}
}
