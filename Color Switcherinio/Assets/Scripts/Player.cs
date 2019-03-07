using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Player instance;

    public float speed;
    public Rigidbody2D playerRigidBody;

    public Colors currentColor;

	// Use this for initialization
	void Awake ()
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

    private void Start()
    {
        int index = Random.Range(0, 4);
        currentColor = (Colors)index;
        ChangeColor(index);
        Debug.Log("Color"+  index);
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

    public void ChangeColor(int colorToChange)
    {
        switch (colorToChange)
        {
            case 0:
                GetComponent<SpriteRenderer>().color = new Color(255f/255f, 5f/255f, 128f/255f);
                currentColor = Colors.PINK;
                break;
            case 1:
                GetComponent<SpriteRenderer>().color = Color.cyan;
                currentColor = Colors.CYAN;
                break;
            case 2:
                GetComponent<SpriteRenderer>().color = new Color(143 / 255f, 16 / 255f, 253 / 255f);
                break;
            case 3:
                GetComponent<SpriteRenderer>().color = Color.yellow;
                currentColor = Colors.YELLOW;
                break;

        };
    }
}
