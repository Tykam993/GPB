using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MusicTimer : NetworkBehaviour {

    [SyncVar]
    public bool fire;
    float timeLeft;
    [SerializeField]
    private AudioSource drawSound;
    private bool shot;

	// Use this for initialization
	void Start () {
        fire = false;
        timeLeft = 10f;
        shot = false;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft <= 0)
        {
            Debug.Log("Time");

            int bang = Random.Range(1, 21);
            Debug.Log(bang);
            if (bang == 10)
            {

                if (!shot)
                {
                    drawSound.Play();
                    shot = true;
                }
                fire = true;

            }
           
        }
	}
}
