using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	
	public int playerStrenght, playerAgility, playerIntelligence, playerEndurace;
	private void Awake() 
	{
		DontDestroyOnLoad(gameObject);
		setStats();
	}
	
	// stats
	// optional values are for debug only
	void setStats ( int strenght = 10, int agility = 10, int intelligence = 10, int endurace = 10 ) 
	{
		playerStrenght = strenght;
		playerAgility = agility;
		playerIntelligence = intelligence;
		playerEndurace = endurace;
	}

}
