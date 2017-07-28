using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hightscore : MonoBehaviour {
     public GameObject obj;
	// Use this for initialization
	void Start () {
        if (score.highscore)
        {
            obj.SetActive(true);
            score.highscore = false;
        }
        else
            obj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
