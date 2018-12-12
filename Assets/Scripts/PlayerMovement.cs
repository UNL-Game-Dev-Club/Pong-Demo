using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    float deadValue;
    float speed;
    
    [SerializeField]
    float verticalInput;

    Rigidbody thisRigidbody;

	// Use this for initialization
	void Start () {
        deadValue = 0.5f;
        speed = 3.0f;
        verticalInput = 0.0f;

        thisRigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        verticalInput = Input.GetAxis("Vertical");

        if (verticalInput > deadValue)
        {
            // Move Up
            Vector2 translationVector = new Vector2();
            translationVector.x = 0.0f;
            translationVector.y = speed * Time.deltaTime;
            this.transform.Translate(translationVector);

        }
        else if (verticalInput < 0 - deadValue)
        {
            // Move Down
            Vector2 translationVector = new Vector2();
            translationVector.x = 0.0f;
            translationVector.y = -1 * speed * Time.deltaTime;
            this.transform.Translate(translationVector);
        }
        else
        {
            // Stay still
            thisRigidbody.velocity = Vector3.zero;
            thisRigidbody.angularVelocity = Vector3.zero;
        }
    }
}
