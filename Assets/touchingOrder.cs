using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchingOrder : MonoBehaviour {

    public GameObject instructions;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;

    public float startTime;
    public int count = 0;
    public int totalCount = 0;
    public int score = 0;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        instructions.SetActive(true);
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        if (time >= startTime + 5.0f)
        {
            instructions.SetActive(false);
            one.SetActive(true);
            two.SetActive(true);
            three.SetActive(true);
            four.SetActive(true);
            five.SetActive(true);
            A.SetActive(true);
            B.SetActive(true);
            C.SetActive(true);
            D.SetActive(true);
            E.SetActive(true);
        }

        if(count == 10)
        {
            if (count == totalCount)
            {
                score = 1;
            }
            else if (count < totalCount)
            {
                score = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "1" && count == 0)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "A" && count == 1)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "2" && count == 2)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "B" && count == 3)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "3" && count == 4)
        {
            totalCount++;
            count++;
        }
        else if(other.name == "C" && count == 5)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "4" && count == 6)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "D" && count == 7)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "5" && count == 8)
        {
            totalCount++;
            count++;
        }
        else if (other.name == "E" && count == 9)
        {
            totalCount++;
            count++;
        }
        else
        {
            totalCount++;
        }
    }
}
