using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAttackColl : AttackColl
{

	readonly int DEFAULTSLOTS = 6;
	int maxNumOfSlots;
	int currentNumOfSlots;

	public FighterAttackColl()
	{
		maxNumOfSlots = DEFAULTSLOTS;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	public FighterAttackColl(int i){
		maxNumOfSlots = i;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	new public void insert(AttackObject a)
	{
		if (currentNumOfSlots + a.getSize() <= maxNumOfSlots) {
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

	new public void omit(AttackObject a)
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


