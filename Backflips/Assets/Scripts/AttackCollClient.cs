using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollClient : MonoBehaviour {

	public void Start(){

		AttackColl P = new AttackColl ();
		AttackColl N = new AttackColl ();

		P.insert (new Attack ("doggo",3, 4));
		P.insert (new Attack ("cat", 9, 10));
		P.insert (new Attack ("bird", 88, 22));

		P.omit (new Attack ("cat", 9, 10));

		N.insert (new Attack ("doggo", 3, 4));
		N.insert (new Attack ("bird", 88, 22));

		N.omit (new Attack ("doggo", 3, 4));
		N.omit (new Attack ("bird", 88, 22));

		N.insert (new Attack ("doggo", 3, 4));
		N.insert (new Attack ("bird", 88, 22));

		N.print ();
		P.print ();
		Debug.Log(P.belongs(new Attack("doggo",3,4)));
		Debug.Log (N.equals (P));

	}
}
