using UnityEngine;
using System.Collections;
using System.IO;

public class AttackManager : MonoBehaviour {

	readonly string AttackListPath = "Documents/AttackList.txt";
	public AttackColl attackColl;

	// Use this for initialization
	void Start () {

		string line;
		attackColl = new AttackColl ();
		StreamReader file = new StreamReader (AttackListPath);

		while((line = file.ReadLine()) != null)
		{
			string[] a = line.Split ();

			Size s = Size.NULL;
			switch (int.Parse(a [3]))
			{
			case 1:
				s = Size.ONE;
				break;
			case 2:
				s = Size.TWO;
				break;
			case 3:
				s = Size.THREE;
				break;
			case 4:
				s = Size.FOUR;
				break;
			case 6:
				s = Size.SIX;
				break;
			}

			AttackObject attack = new AttackObject
				(a [0], int.Parse (a [1]), int.Parse (a [2]), s);

			attackColl.insert (attack);
		}

		attackColl.print ();

		file.Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
