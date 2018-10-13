using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clapRight : MonoBehaviour {

    public GameObject letterSeries;
    public GameObject gap;

    public bool bump;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "Clap Range" && other.name == "Clap Area")
        {
            bump = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        bump = false;
    }
}
