using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.y < Player.instance.transform.position.y)
        {
            Vector3 camera = transform.position;

            //so, it's imposible to modify x/y/z parameter of position variable  so we do this
            camera.y = Player.instance.transform.position.y;

            transform.position = camera;
        }
	}
}
