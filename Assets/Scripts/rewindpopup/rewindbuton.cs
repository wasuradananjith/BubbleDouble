using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rewindbuton : MonoBehaviour {
    public GameObject pannel;
    string rewindcountKey = "rewindboosters";
    public int rewindcount;
	// Use this for initialization
    public void onclick()
    {
        rewindcount = PlayerPrefs.GetInt(rewindcountKey, 0);
        rewindcount--;
        PlayerPrefs.SetInt(rewindcountKey, rewindcount);
        pauseplay.isPaused = false;
        SceneManager.LoadScene("Bouble Double");
        PlayerPrefs.Save();
        pannel.SetActive(false);
    }
}
