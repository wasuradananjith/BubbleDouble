using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usestartupboost : MonoBehaviour {
    public Button startupbutton;
    string coinKey = "coins";
    public int coins;
    public static int boostercount;
    string startcountKey = "startboosters";
	// Use this for initialization
	void Start () {
        coins = PlayerPrefs.GetInt(coinKey,0);
        boostercount = PlayerPrefs.GetInt(startcountKey, 0);
        if (boostercount == 0)
        {
            GameObject.Find("done").GetComponent<Renderer>().enabled = false;
        }
        if (boostercount >= 1)
        {
            startupbutton.interactable = false;
        }

       
	}
	
	// Update is called once per frame
	void Update () {
        if (coins < 1000)
        {
            startupbutton.interactable = false;
        }

           
	}
    public void onclickbutton()
    {
        boostercount++;
        coins -= 1000;
        startupbutton.interactable = false;
        GameObject.Find("done").GetComponent<Renderer>().enabled = true;
        PlayerPrefs.SetInt(startcountKey, 0);
        PlayerPrefs.SetInt(coinKey, coins);
        PlayerPrefs.Save();
    }

}
