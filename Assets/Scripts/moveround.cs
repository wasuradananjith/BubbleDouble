using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveround : MonoBehaviour {
    public float xspeed=2f;
    public float yspeed=2f;

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(xspeed*Time.deltaTime, yspeed*Time.deltaTime, 0);
        if(gameObject.transform.position.x>2.61)
            xspeed=-xspeed;
        if (gameObject.transform.position.y > 3.87)
            yspeed = -yspeed;
        if (gameObject.transform.position.x < -2.09)
            xspeed = -xspeed;
        if (gameObject.transform.position.y<-4.62)
            yspeed = -yspeed;


	}
}
