using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class skip : MonoBehaviour {

	// Use this for initialization
    public void onclick()
    {
        SceneManager.LoadScene("Gameover");
    }
}
