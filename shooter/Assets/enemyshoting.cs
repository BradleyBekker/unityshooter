using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoting : MonoBehaviour
{

    // Use this for initialization
    private Vector3 velocity = new Vector3(0, -20, 0);
    private Vector3 acceleration = new Vector3(1, 1, 1);
    private float destroytimer = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = velocity + acceleration * Time.deltaTime;
        transform.position = transform.position + velocity * Time.deltaTime;
        destroytimer += Time.deltaTime;
        if (destroytimer > 4)
        {
            DestroyObject(gameObject);
        }

        // Update is called once per frame

    }
}
