using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{

	private List<Unit> units;
	
	// Use this for initialization
	void Start () {
		units = new List<Unit>();
		GameObject [] playerUnits = GameObject.FindGameObjectsWithTag("Player");
		GameObject [] enemyUnits = GameObject.FindGameObjectsWithTag("Enemy");
		
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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
