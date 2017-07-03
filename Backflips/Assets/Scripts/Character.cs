using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	readonly string DEFAULTTITLE = "nameless";
	public string title;

	public Character(){
		title = DEFAULTTITLE;
	}

	public Character(string title)
	{
		this.title = title;
	}
}