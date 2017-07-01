using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackList : MonoBehaviour {

	readonly int MAXNUMOFATTACKS = 4;
	LinkedList<Attack> a;
	int numOfAttacks;
	Attack tackle;

	public AttackList()
	{
		a = new LinkedList<Attack>();
		numOfAttacks = 1;
		tackle = new Attack();
	}

	public void addAttack(Attack att)
	{
		if(numOfAttacks != MAXNUMOFATTACKS)
		{
			numOfAttacks++;
			a.AddFirst(att);
		}
	}

	public void update()
	{
		for(int x = 0; x < numOfAttacks; x++)
		{
			// TODO: finish this
			// TODO: make a LinkedList class cuz the unity one is S H I T
		}
	}
}
