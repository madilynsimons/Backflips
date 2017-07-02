using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAttackColl : AttackColl
{

	AttackManager ATTACKS;
	readonly int DEFAULTSLOTS = 6;
	int maxNumOfSlots;
	int currentNumOfSlots;

	public FighterAttackColl()
	{
		ATTACKS = new AttackManager ();
		maxNumOfSlots = DEFAULTSLOTS;
		currentNumOfSlots = maxNumOfSlots;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	public FighterAttackColl(int i){
		ATTACKS = new AttackManager ();
		maxNumOfSlots = i;
		currentNumOfSlots = maxNumOfSlots;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	public void insert(string name)
	{
		AttackObject[] arr = ATTACKS.toArray ();
		for (int x = 0; x< arr.Length; x++) {
			if (arr [x].getTitle () == name) {
				insert (arr [x]);
				x = arr.Length;
			}

		}
	}

	public override void insert(AttackObject a)
	{
		
		if (a!=null && ATTACKS.belongs (a)) {
			if (currentNumOfSlots + a.getSize () <= maxNumOfSlots) {
				Node p = c;
				while ((p != null) && (p.attack != a)) {
					p = p.link;
				}
				if (p == null) {
					howMany++;
					p = new Node (a, c);
					c = p;
				}
				currentNumOfSlots += a.getSize ();
			}
		}
	}
		

	public override void omit(AttackObject a)
	{
		if (a.getTitle() != "TACKLE") {
			Node p = c;
			Node previous = null;
			while ((p != null) && (p.attack != a)) {
				previous = p;
				p = p.link;
			}
			if (p != null) {
				if (previous == null) {
					p = p.link;
					c = p;
				} else {
					previous.link = p.link;
				}
				howMany--;
				currentNumOfSlots -= a.getSize ();
			}
		}
	}
		
}


