﻿using UnityEngine;
using System.Collections;
#pragma warning disable 0414
#pragma warning disable 0618

public class ButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTouchIn()
    {
        if(gameObject.name == "Button_GoToLevel")
        {

            Application.LoadLevel("Play");
        }
    }

}
