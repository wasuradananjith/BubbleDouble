using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyfree : MonoBehaviour {
    public Text boosterscount;
    public int coins,freecount;
    string coinKey = "coins";
    public Text discoin;
    string freecountKey = "freeboosters";
    public Button freebutton;
	// Use this for initialization
    void Start()
    {
        freecount = PlayerPrefs.GetInt(freecountKey, 0);
        coins = PlayerPrefs.GetInt(coinKey,0);
        boosterscount.text = freecount.ToString();
       
    }
    public void Update()
    {
        if (coins <= 1500)
        {
            freebutton.interactable = false;

        }
    }
   public void onclick()
    {
            freecount++;
            coins -= 1500;
            boosterscount.text = freecount.ToString();
            discoin.text = coins.ToString();

        PlayerPrefs.SetInt(freecountKey,freecount);
        PlayerPrefs.SetInt(coinKey, coins);
        PlayerPrefs.Save();
    }

}
