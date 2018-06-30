using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cub_Rotate : MonoBehaviour {

    public float speed, tilt;
    public Vector3 target;
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        if(transform.position == target && target.y==1.35f)
        {
            target.y = 0.05f;
        }
        else if (transform.position == target && target.y == 0.05f)
        {
            target.y = 1.35f;
        }
        transform.Rotate(Vector3.up  * Time.deltaTime * tilt);
	}
}
