using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Spawner").GetComponent<Spawner>().currentObstacles.Remove(collision.gameObject.transform.parent);
        Destroy(collision.gameObject.transform.parent.gameObject);
    }
}
