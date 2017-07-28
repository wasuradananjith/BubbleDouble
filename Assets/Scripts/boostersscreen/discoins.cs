using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class discoins : MonoBehaviour {
    public Text discoin;
    string coinKey = "coins";
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        discoin.text = PlayerPrefs.GetInt(coinKey, 0).ToString();
	}
}
