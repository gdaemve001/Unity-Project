using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Monster : MonoBehaviour {

	int strenght;
	int inteligence;
	int dexterity;
	int wisdom;
	int endurance;
	int speed;
	int luck;

	int health;
	int mana;

	Race race;
	Profession profession; // class is reserved word had to change it to other one
	Element fElement;
	Element sElement;

	bool disabled; //stunning and alikes

	Ability[]  abilities; // holds all character abilites
	StatusAliment[] aliments; // current status aliments ongoing 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Attack() {

	}

	void Die() {

	}

	void UseAbility(){
		
	}

	void BeginTurn() {
		ApplyStatuses ();
	}

	void EndTurn() {

	}

	void ApplyStatuses() {

	}
}
