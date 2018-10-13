using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intoBox : MonoBehaviour {

    public int count = 0;
    public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if( score >= 1)
        {
            score = count - 1;
        }
        else
        {
            score = count;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "fruit" && other.name == "fruit box")
        {
            count++;
        }
        else if (gameObject.name == "transport" && other.name == "transport box")
        {
            count++;
        }
        else if (gameObject.name == "tool" && other.name == "tool box")
        {
            count++;
        }
    }
}
