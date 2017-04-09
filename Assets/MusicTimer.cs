using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MusicTimer : NetworkBehaviour {

    [SyncVar]
    public bool fire;
    float timeLeft;

	// Use this for initialization
	void Start () {
        fire = false;
        timeLeft = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft <= 0)
        {
            Debug.Log("Time");

            int bang = Random.Range(1, 11);
            Debug.Log(bang);
            if (bang == 10)
                fire = true;
        }
	}
}
