using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StripeMini : MonoBehaviour {

    private Stripe stripe;
        
    private void Start()
    {
        stripe = gameObject.GetComponentInParent<Stripe>();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(new Vector3(stripe.speed * Time.deltaTime, 0, 0));
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            Stripe stripe = gameObject.GetComponentInParent<Stripe>();

            stripe.miniStripes.RemoveFirst();

            if (stripe.speed < 0)
            {
                transform.position = stripe.miniStripes.Last.Value.position + new Vector3(1.6f, 0, 0);
            }
            else
            {
                transform.position = stripe.miniStripes.Last.Value.position - new Vector3(1.6f, 0, 0);   
            }

            stripe.miniStripes.AddLast(transform);

        }

        
    }

}
