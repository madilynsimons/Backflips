using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackObject {

	readonly string DEFAULTTITLE = "nameless";
	readonly int DEFAULTPP = 20;
	readonly Size DEFAULTSIZE = Size.ONE;

	string title;
	int maxPP, currentPP;
	Size size;

	public AttackObject()
	{
		title = DEFAULTTITLE;
		maxPP = DEFAULTPP;
		currentPP = DEFAULTPP;
		size = DEFAULTSIZE;
	}

	public AttackObject(string title, int pp, Size size)
	{
		this.title = title;
		maxPP = pp;
		currentPP = pp;
		this.size = size;
	}

	public AttackObject(AttackObject a)
	{
		title = a.title;
		maxPP = a.maxPP;
		currentPP = a.maxPP;
		size = a.size;
	}

	public int getSize()
	{
		return (int)size;
	}

	public static bool operator ==(AttackObject a, AttackObject b)
	{
		return a.title == b.title && a.maxPP == b.maxPP;
	}

	public static bool operator !=(AttackObject a, AttackObject b)
	{
		return !(a.title == b.title && a.maxPP == b.maxPP);
	}

	public string getTitle()
	{
		return title;
	}

	public string toString()
	{
		return this.title;
	}
}
