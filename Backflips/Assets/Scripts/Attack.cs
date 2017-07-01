using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack {

	readonly string DEFAULTTITLE = "nameless";
	readonly int DEFAULTPP = 20;
	readonly Size DEFAULTSIZE = Size.ONE;

	string title;
	int maxPP, currentPP;
	Size size;

	public Attack()
	{
		title = DEFAULTTITLE;
		maxPP = DEFAULTPP;
		currentPP = DEFAULTPP;
		size = DEFAULTSIZE;
	}

	public Attack(string title, int pp, int damage, Size size)
	{
		this.title = title;
		maxPP = pp;
		currentPP = pp;
		this.size = size;
	}

	public Attack(Attack a)
	{
		title = a.title;
		maxPP = a.maxPP;
		currentPP = a.maxPP;
	}

	public static bool operator ==(Attack a, Attack b)
	{
		return a.title == b.title && a.maxPP == b.maxPP;
	}

	public static bool operator !=(Attack a, Attack b)
	{
		return !(a.title == b.title && a.maxPP == b.maxPP);
	}

	public string toString()
	{
		return this.title;
	}
}
