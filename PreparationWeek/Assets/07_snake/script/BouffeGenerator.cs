﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouffeGenerator : MonoBehaviour {
    public GameObject bouffe;
	// Use this for initialization
	void Start () {
        GameObject newBouffe = Instantiate(bouffe);
        newBouffe.transform.position = new Vector3(Random.Range(-10, 10), 0.5f, Random.Range(-10, 10));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}