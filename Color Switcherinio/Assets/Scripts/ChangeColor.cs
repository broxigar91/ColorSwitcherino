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

    
    public int colorToChange;

    public void Start()
    {
        colorToChange = Random.Range(0, 4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player.instance.ChangeColor(colorToChange);
        }
    }

}
