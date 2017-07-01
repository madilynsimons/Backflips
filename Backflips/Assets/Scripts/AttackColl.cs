using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackColl {

	private Node c;
	private int howMany;

	public AttackColl()
	{
		c = new Node ();
		howMany = 0;
	}

	public int get_howmany()
	{
		return howMany;
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

	public bool belongs(AttackObject a)
	{
		Node p = c;
		while((p != null) && (p.attack != a)){
			p = p.link;
		}
		return p != null;
	}



	public void insert(AttackObject a)
	{
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
