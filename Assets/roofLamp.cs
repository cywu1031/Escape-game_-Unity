﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class roofLamp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void touchLamp()
    {
        GetComponent<ParticleSystem>().Emit(10);
    }
}
