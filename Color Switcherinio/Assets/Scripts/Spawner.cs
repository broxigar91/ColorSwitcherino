using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> obstacleCollection;
    public GameObject obstacleContainer;
    public LinkedList<Transform> currentObstacles;

	// Use this for initialization
	void Start ()
    {
        currentObstacles = new LinkedList<Transform>();

        for(int i=0; i< 4; i++)
        {
            Spawn();
        }		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        GameObject obstacle = Instantiate(obstacleCollection[Random.Range(0, 4)]);

        obstacle.transform.SetParent(obstacleContainer.transform);

        if(currentObstacles.Count!=0)
        {
            Transform lastTransform = currentObstacles.Last.Value.transform;
            obstacle.transform.position = lastTransform.position + Vector3.up * 10;
        }
        
        currentObstacles.AddLast(obstacle.transform);
        
    }
}
