using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    [SerializeField]
    float speed;
    float verticalStep;

    // Use this for initialization
    void Start () {
        speed = 5.0f;
        verticalStep = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        float distanceTraveled = speed * Time.deltaTime;
        float verticalTraveled = verticalStep * Time.deltaTime;

        Vector2 translationVector = new Vector2();
        translationVector.x = distanceTraveled;
        translationVector.y = verticalTraveled;
        this.transform.Translate(translationVector);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.Contains("Paddle"))
        {
            ChangeHorizontalDirection();
        }
        else if (collision.collider.name.Contains("Wall"))
        {
            ChangeVerticalStepDirection();
        }
    }

    void ChangeHorizontalDirection()
    {
        speed = -1 * speed;
        verticalStep = Random.value;
    }
    
    void ChangeVerticalStepDirection()
    {
        verticalStep = -1 * verticalStep;
    }
}
