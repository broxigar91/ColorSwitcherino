using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player instance;

    public float speed;
    public Rigidbody2D playerRigidBody;
    public Colors currentColor;

	// Use this for initialization
	void Start ()
    {
		if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && GameManager.instance.gameState == GameState.PLAYING)
        {
            playerRigidBody.velocity = Vector2.up * speed;
        }

        if(GameManager.instance.gameState == GameState.GAMEOVER)
        {
            playerRigidBody.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
