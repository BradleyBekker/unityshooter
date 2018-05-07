using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour {

    public GameObject sphere;
    public float Speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            shoot();
    }
    void shoot()
    {
        Vector3 shotpos = new Vector3 (transform.position.x, transform.position.y + 2.1f, transform.position.z);
        Instantiate(sphere, shotpos, Quaternion.identity);
    }
}
