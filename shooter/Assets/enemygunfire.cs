using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygunfire : MonoBehaviour {
    public GameObject sphere;
    private float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Vector3 shotpos = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
            Instantiate(sphere, shotpos, transform.rotation);
            timer = 0;
        }
        

    }
}
