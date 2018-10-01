using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    float velocity = 0.10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position; //gets position
        position.x = position.x + velocity; //edits position
        //set new position
        transform.position = position;
    }

    //action taken on collision
    private void OnCollisionEnter(Collision collision)
    {
        velocity *= -1;
        
    }

}
