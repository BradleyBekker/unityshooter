using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public GameObject sphere;
    public float Speed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Speed = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(19, 0, 0);
        transform.Translate(direction * Speed * Time.deltaTime);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyObject(gameObject);
    }

}
