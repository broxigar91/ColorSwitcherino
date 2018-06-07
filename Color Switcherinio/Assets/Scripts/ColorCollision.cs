using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorCollision : MonoBehaviour {

    public Colors color;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(color != Player.instance.currentColor)
            {
                GameManager.instance.gameState = GameState.GAMEOVER;
                Debug.Log("GAME OVER");
            }
        }
    }
}
