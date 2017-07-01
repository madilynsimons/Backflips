using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAttackColl : AttackColl
{

	readonly int NUMOFATTACKSDEFAULT = 6;
	int maxNumOfAttacks;

	public FighterAttackColl()
	{
		maxNumOfAttacks = NUMOFATTACKSDEFAULT;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	public FighterAttackColl(int i){
		maxNumOfAttacks = i;
		c = new Node ();
		howMany = 0;
		insert ("TACKLE");
	}

	new public void insert(AttackObject a)
	{
		if (howMany < maxNumOfAttacks) {
			Node p = c;
			while ((p != null) && (p.attack != a)) {
				p = p.link;
			}
			if (p == null) {
				howMany++;
				p = new Node (a, c);
				c = p;
			}
		}
	}

	new public void omit(AttackObject a)
	{
		if (howMany > 1) {
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
			}
		}
	}
		
}


