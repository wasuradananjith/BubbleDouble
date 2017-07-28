using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontuchcoin : MonoBehaviour {
    public int coins;
    string coinKey = "coins";
    public static int sessioncoins=0;
    public AudioSource sound;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        if (!PlayerPrefs.HasKey(coinKey))
        {
            PlayerPrefs.SetInt(coinKey,0);
        }
        coins = PlayerPrefs.GetInt(coinKey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        sound.Play();
        gameObject.GetComponent<Renderer>().enabled = false;
        sessioncoins += 50;
        coins += 50;
        PlayerPrefs.SetInt(coinKey,coins);

    }
}
