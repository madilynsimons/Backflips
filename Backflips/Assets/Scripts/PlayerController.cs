using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

	public float speed;
	private Rigidbody2D rb2d;
	private Vector2 player;

	void Start(){
    	rb2d = GetComponent<Rigidbody2D>();
  	}

	void Update(){
		player.x = Input.GetAxisRaw ("Horizontal");
		player.y = Input.GetAxisRaw ("Vertical");
	}


	void FixedUpdate(){
		rb2d.velocity = player * speed;
	}

}
