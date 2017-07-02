using UnityEngine;
using System.Collections;
using System.IO;

public class AttackManager : AttackColl {

	readonly static string AttackListPath = "Documents/Attacks/AttackList.txt";

	// Use this for initialization
	public AttackManager () {

		string line;
		StreamReader file = new StreamReader (AttackListPath);
		int hCode = 0;

		while((line = file.ReadLine()) != null)
		{
			string[] a = line.Split ();

			Size s = Size.NULL;
			switch (int.Parse(a [2]))
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
				(a [0], int.Parse (a [1]), s, hCode);

			insert (attack);
			hCode++;
		}

		// uncomment for debugging purposes
		//print ();

		file.Close ();
	}

}
