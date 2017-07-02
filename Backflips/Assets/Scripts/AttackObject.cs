using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AttackObject {
	

	readonly string DEFAULTTITLE = "nameless";
	readonly int DEFAULTPP = 20;
	readonly Size DEFAULTSIZE = Size.ONE;

	string title;
	int maxPP, currentPP;
	Size size;
	int hCode;

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

	public AttackObject(string title, int pp, Size size, int hCode)
	{
		this.title = title;
		maxPP = pp;
		currentPP = pp;
		this.size = size;
		this.hCode = hCode;
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

		if (System.Object.ReferenceEquals(a, null))
		{
			if (System.Object.ReferenceEquals(b, null))
			{
				return true;
			}
			return false;
		}

		bool result;
		try{
			result = (a.title == b.title && a.maxPP == b.maxPP);
		}catch(NullReferenceException e){
			return false;
		}
		return result;
	}

	public static bool operator !=(AttackObject a, AttackObject b)
	{

		return !(a==b);
	}

	public override bool Equals(object o)
	{
		try{
			if((AttackObject)o==this) return true;
			throw new UnityException();
		}catch(UnityException e){
			Debug.Log (e + " AttackObject.cs line 84");
			return false;
		}
	}

	public override int GetHashCode()
	{

		return hCode;
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
