using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygun : MonoBehaviour {
    float Speed;
    public GameObject Boss;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveball();

    }

    void moveball()
    {

        
        Vector3 direction = new Vector3(9, 0, 0);
        transform.Translate(direction * Speed * Time.deltaTime);


        if (transform.position.x <= -20)
        {
            Speed = 2;
 
            transform.Translate(direction * Speed * Time.deltaTime);
        }
        if (transform.position.x >= 20)
        {
            Speed = -2;
            print("edge");
            transform.Translate(direction * Speed * Time.deltaTime);
        }

       

    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyObject(gameObject);
        Vector3 spawnpos = new Vector3(transform.position.x, 25, transform.position.z);

        Instantiate(Boss, spawnpos, Quaternion.identity);

    }

}
