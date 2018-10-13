using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clapNow : MonoBehaviour {

    public GameObject series;
    public clapRight script;
    public int score = 0;
    public int count = 0;

    // Use this for initialization
    void Start () {
        script = series.GetComponent<clapRight>();
	}
	
	// Update is called once per frame
	void Update () {
		if(script.bump == true && Input.GetButton("sdf"))
        {
            count++;
        }

        if(count == 11)
        {
            score = 1;
        }
	}
}
