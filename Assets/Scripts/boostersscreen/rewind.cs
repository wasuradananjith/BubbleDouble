using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rewind : MonoBehaviour {
    public Text boosterscount;
    public int coins, rewindcount;
    string coinKey = "coins";
    public Text discoin;
    string rewindcountKey = "rewindboosters";
    public Button rewindbutton;
	// Use this for initialization
    void Start()
    {
        rewindcount = PlayerPrefs.GetInt(rewindcountKey, 0);
        coins = PlayerPrefs.GetInt(coinKey,0);
        boosterscount.text = rewindcount.ToString();

    }
    public void Update()
    {
        if (coins <= 2500)
        {
            rewindbutton.interactable = false;

        }
    }
    public void onclick()
    {
        rewindcount++;
        coins -= 2500;
        boosterscount.text = rewindcount.ToString();
        discoin.text = coins.ToString();

        PlayerPrefs.SetInt(rewindcountKey, rewindcount);
        PlayerPrefs.SetInt(coinKey, coins);
        PlayerPrefs.Save();
    }
}
