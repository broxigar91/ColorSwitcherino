using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public int points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.score += points;
        Destroy(gameObject);
    }
}
