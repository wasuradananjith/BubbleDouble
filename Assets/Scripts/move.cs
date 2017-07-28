using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed = 5f;
	
	void Start () {
		
	}
	
	
	void Update () {
        if (gameObject.transform.position.y > 3.87)
        {
            gameObject.GetComponent <Renderer>().enabled= false;
        }
        transform.Translate(0, speed * Time.deltaTime,0);
	}
}
