using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Stripe : MonoBehaviour {

    public LinkedList<Transform> miniStripes;
    public int speed;

	// Use this for initialization
	void Start () {

        miniStripes = new LinkedList<Transform>();

        for(int i=0; i< transform.childCount;i++)
        {
            miniStripes.AddLast(transform.GetChild(i));
        }

	}

}
