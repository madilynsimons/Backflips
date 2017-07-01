using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack {

	readonly string DEFAULTTITLE = "nameless";
	readonly int DEFAULTPP = 20;
	readonly int DEFAULTDAMAGE = 10;
	string title;
	int maxPP, currentPP;
	int damage;

	public Attack()
	{
		title = DEFAULTTITLE;
		maxPP = DEFAULTPP;
		currentPP = DEFAULTPP;
		damage = DEFAULTDAMAGE;
	}

	public Attack(string title, int pp, int damage)
	{
		this.title = title;
		maxPP = pp;
		currentPP = pp;
		this.damage = damage;
	}

	public Attack(Attack a)
	{
		title = a.title;
		maxPP = a.maxPP;
		currentPP = a.maxPP;
		damage = a.damage;
	}

	public static bool operator ==(Attack a, Attack b)
	{
		return a.title == b.title && a.maxPP == b.maxPP && a.damage == b.damage;
	}

	public static bool operator !=(Attack a, Attack b)
	{
		return !(a.title == b.title && a.maxPP == b.maxPP && a.damage == b.damage);
	}

	public string toString()
	{
		return this.title;
	}
}
