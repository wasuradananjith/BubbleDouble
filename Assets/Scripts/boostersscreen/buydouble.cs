using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buydouble : MonoBehaviour {
    public Text boosterscount;
    public int coins, doublecount;
    string coinKey = "coins";
    public Text discoin;
    string doublecountKey = "doubleboosters";
   public Button doublebutton;
	// Use this for initialization
	void Start () {
        doublecount = PlayerPrefs.GetInt(doublecountKey, 0);
        coins = PlayerPrefs.GetInt(coinKey,0);
        boosterscount.text = doublecount.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (coins <= 2000)
        {
            doublebutton.interactable = false;
        }
	}
    public void onclick()
    {

            doublecount++;
            coins -= 2000;
            boosterscount.text = doublecount.ToString();
            discoin.text = coins.ToString();
        PlayerPrefs.SetInt(doublecountKey, doublecount);
        PlayerPrefs.SetInt(coinKey, coins);
        PlayerPrefs.Save();
    }
}
