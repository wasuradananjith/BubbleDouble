using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverscene : MonoBehaviour {

	
    public void home() {
        ontuchcoin.sessioncoins = 0;
        score.tscore = 0;
        pauseplay.isPaused = false;
        SceneManager.LoadScene("Homescreen");
    
    }
    public void restart() {
        ontuchcoin.sessioncoins = 0;
        score.tscore = 0;
        pauseplay.isPaused = false;
        SceneManager.LoadScene("Bouble Double");
    }


}
