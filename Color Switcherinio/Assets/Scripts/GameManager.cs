using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    MENU,
    PLAYING,
    GAMEOVER,
    PAUSE
}


public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public GameState gameState;
    public int score;

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
        //gameState = GameState.MENU;
        score = 0;
    }

    // Update is called once per frame
    void Update () {
		
        

	}
}
