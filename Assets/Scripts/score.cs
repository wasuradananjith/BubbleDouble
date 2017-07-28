using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static bool highscore = false;
    public static int tscore = 0;
    public static int highScore = 0;
    public static int freecount = 0;
    public Text disscore,dishighscore,free;
    public static float speed = 2f;
    string highScoreKey = "HighScore";
    string freecountKey = "freeboosters";
    string startcountKey = "startboosters";
 //   public int doubled;
    
    void Start()
    {
       // doubled = PlayerPrefs.GetInt(startcountKey, 0);
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        
        freecount = PlayerPrefs.GetInt(freecountKey, 0);
        if (usestartupboost.boostercount>= 1)
        {
            tscore += 500;
            usestartupboost.boostercount -= 1;
        }
        PlayerPrefs.SetInt(startcountKey,usestartupboost.boostercount);
        PlayerPrefs.Save();
        
    }

   
    void Update()
    {
        disscore.text = tscore.ToString();
        dishighscore.text = highScore.ToString();
        free.text = freecount.ToString();
        if (tscore > 1500)
        {
            speed = 2f;
        }
        else if (tscore > 1300)
        {
            speed = 1.2f;
        }
        else if (tscore > 800)
        {
            speed = 1.3f;
        }
        else if (tscore > 500)
        {
            speed = 1.5f;
        }
        if (tscore > highScore)
        {
            highscore = true;
            dishighscore.text = tscore.ToString();
            PlayerPrefs.SetInt(highScoreKey, tscore);
            
        }
    }
}
