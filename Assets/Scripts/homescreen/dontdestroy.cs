using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {
    
	// Use this for initialization
    AudioSource aus;
    void Start()
    {
        aus = this.gameObject.GetComponent<AudioSource>();
        aus.Play();
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
