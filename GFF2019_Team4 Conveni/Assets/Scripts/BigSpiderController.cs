﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSpiderController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーおいしー^^　");

            //Destroy(this.gameObject);
        }
    }
}


