using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Turn Helper inherits the MonoBehaviour class
public class TurnSystem : TurnHelper
{	
	// Use this for initialization
	void Start () {
		units = new List<Unit>();
		//Arrays for player and enemy units
		var playerUnits = GameObject.FindGameObjectsWithTag("Player");
		var enemyUnits = GameObject.FindGameObjectsWithTag("Enemy");
		
		foreach (GameObject player in playerUnits) {
			var currentUnit = player.GetComponent<Unit> ();
			currentUnit.Turn (0);
			units.Add (currentUnit);
		}
		foreach (GameObject enemy in enemyUnits) {
			var currentUnit = enemy.GetComponent<Unit> ();
			currentUnit.Turn (0);
			units.Add (currentUnit);
		}

		TurnSort();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
