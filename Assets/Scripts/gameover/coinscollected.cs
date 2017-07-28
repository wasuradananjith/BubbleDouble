using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscollected : MonoBehaviour {
    public Text coinscoll;
	// Use this for initialization
	void Start () {
        coinscoll.text = ontuchcoin.sessioncoins.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
