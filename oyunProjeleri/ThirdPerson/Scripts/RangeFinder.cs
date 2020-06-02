using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeFinder : MonoBehaviour {
    // Use this for initialization
    public bool Inrange { get; set; }
    public Transform hedef;
    public Quaternion Pozisyo;
    void Start () {
        Inrange = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Inrange = true;
          Pozisyo = other.transform.rotation;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Inrange = false;
        }
    }
}
