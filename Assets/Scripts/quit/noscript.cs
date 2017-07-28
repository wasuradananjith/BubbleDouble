using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class noscript : MonoBehaviour {

    public GameObject panel;
    public void onclick()
    {
       
        panel.SetActive(false);
    }
}
