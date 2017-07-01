using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackColl {

	protected Node c;
	protected int howMany;
	public AttackManager attackManager;

	public AttackColl()
	{
		c = new Node ();
		howMany = 0;
	}

	public int get_howmany()
	{
		return howMany;
	}

	// TODO -- test this method
	public AttackObject getAttack(int index)
	{
		if (howMany >= index) {
			throw new UnassignedReferenceException ();
			return null;
		} else if (index == 0) {
			return c.attack;
		} else {
			Node p = c;
			for (int y = 0; y < index; y++) {
				p = p.link;
			}
			return p.attack;
		}
	}

	public void copy(AttackColl obj)
	{
		if (this != obj)
		{
			this.howMany = obj.get_howmany();
			if (obj.c == null) {
				c = null;
			} else {
				c = new Node ();
				c.attack = new AttackObject (obj.c.attack);
				Node q = obj.c.link;
				Node p = c;
				while (q != null) {
					p.link = new Node();
					p = p.link;
					p.attack = new AttackObject(q.attack);
					q = q.link;
				}
			}
		}
	}

	public AttackObject getAttack(string title)
	{
		Node p = c;
		while((p != null) && (p.attack.getTitle() != title)){
			p = p.link;
		}
		if (p != null)
			return p.attack;
		return null;
	}

	public bool belongs(AttackObject a)
	{
		Node p = c;
		while((p != null) && (p.attack != a)){
			p = p.link;
		}
		return p != null;
	}

	public bool belongs(string name)
	{
		Node p = c;
		while((p != null) && (p.attack.getTitle() != name)){
			p = p.link;
		}
		return p != null;
	}
		
	public void insert(AttackObject a)
	{
		if (a != null) {
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

	public void insert(string title)
	{
		insert (getAttack (title));
	}

	public void omit(AttackObject a)
	{
		Node p = c;
		Node previous = null;
		while ((p != null) && (p.attack != a))
		{
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

	public void print()
	{
		Node p = c;
		int j = 0;
		while (j < howMany){
			Debug.Log (p.attack.toString());
			p = p.link;
			j++;
		}
	}

	public bool equals(AttackColl obj)
	{
		Node p = c;
		if (obj.get_howmany () == howMany) {
			while ((p != null) && (obj.belongs (p.attack))) {
				p = p.link;
			}
		}return p == null;
	}

	public class Node
	{
		public AttackObject attack;
		public Node link;

		public Node()
		{
			attack = new AttackObject();
			link = null;
		}

		public Node(AttackObject attack, Node link)
		{
			this.attack = attack;
			this.link = link;
		}
	}
}
