using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colors
{
    PINK,
    YELLOW,
    CYAN,
    PURPLE
}

public class ChangeColor : MonoBehaviour {

    [HideInInspector]
    public Colors colorToChange = new Colors();

    public void Start()
    {
        colorToChange = (Colors)Random.Range(0, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            switch(colorToChange)                
            {
                case Colors.PINK:
                    Player.instance.GetComponent<SpriteRenderer>().color = Color.magenta;
                    Player.instance.currentColor = Colors.PINK;
                    break;
                case Colors.CYAN:
                    Player.instance.GetComponent<SpriteRenderer>().color = Color.cyan;
                    Player.instance.currentColor = Colors.CYAN;
                    break;
                case Colors.PURPLE:
                    Player.instance.GetComponent<SpriteRenderer>().color = new Color(140,19,255);
                    Player.instance.currentColor = Colors.PURPLE;
                    break;
                case Colors.YELLOW:
                    Player.instance.GetComponent<SpriteRenderer>().color = Color.yellow;
                    Player.instance.currentColor = Colors.YELLOW;
                    break;

            };

            
        }
    }

}
