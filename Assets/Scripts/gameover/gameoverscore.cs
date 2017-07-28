using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverscore : MonoBehaviour {
    public Text goscore;
	// Use this for initialization
	void Start () {
       goscore.text=score.tscore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
