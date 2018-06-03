using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public Rigidbody2D playerRigidBody;

	// Use this for initialization
	void Start () {
		
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidBody.velocity = Vector2.up * speed;
        }
    }
}
