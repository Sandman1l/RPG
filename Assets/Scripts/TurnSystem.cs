using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Turn Helper inherits the MonoBehaviour class
public class TurnSystem : TurnHelper
{	
	// Use this for initialization
	void Start () {
		
		if (Units.Count != 0)
		{
			Units.Clear();
		}
		
		Units = new List<Unit>();
		//Arrays for player and enemy units
		var playerUnits = GameObject.FindGameObjectsWithTag("Player");
		var enemyUnits = GameObject.FindGameObjectsWithTag("Enemy");

		foreach (var player in playerUnits)
		{
			var currentUnit = player.GetComponent<Unit>();
			currentUnit.Turn(0);
			Units.Add(currentUnit);
		}

		foreach (var enemy in enemyUnits)
		{
			var currentUnit = enemy.GetComponent<Unit> ();
			currentUnit.Turn (0);
			Units.Add (currentUnit);
		}

		AgilitySort();
	}
	
	public void nextTurn() {
		var nextToAct = Units [0];
		Units.Remove (nextToAct);
 
		if (!nextToAct.isDead ()) {
			var currentUnit = nextToAct.gameObject;
 
			nextToAct.calculateNextActTurn (nextToAct.nextActTurn);
			Units.Add (nextToAct);
			AgilitySort();

			Debug.Log(currentUnit.CompareTag("PlayerUnit") ? "Player unit acting" : "Enemy unit acting");
		} else {
			this.nextTurn ();
		}
	}
}
