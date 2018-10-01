using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour {

    float deadvalue = 0.5f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //If vertical axis is activated
        float y_input = Input.GetAxis("Vertical");
        if (Mathf.Abs(y_input) > deadvalue)
        {

            Vector2 position = transform.position; //gets position
            position.y = position.y + (0.1f * y_input); //edits position
                                            //set new position
            transform.position = position;
        }
	}
}
