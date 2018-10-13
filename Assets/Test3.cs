using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test3 : MonoBehaviour {

    public GameObject instructions;
    public GameObject face;
    public GameObject church;
    public GameObject daisy;
    public GameObject velvet;
    public GameObject red;

    public float startTime;
    public int count = 0;
    public int again = 0;
    public int instrOnce = 0;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        instructions.SetActive(true);
        face.SetActive(false);
        church.SetActive(false);
        daisy.SetActive(false);
        velvet.SetActive(false);
        red.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate () {
        float time = Time.time;
        Debug.Log(count);
        if (time >= startTime + 5.0f)
        {
            if (count == 0)
            {
                instructions.SetActive(false);
                face.SetActive(true);
                startTime = Time.time;
                count++;
            }
            else if (count == 1)
            {
                face.SetActive(false);
                church.SetActive(true);
                startTime = Time.time;
                count++;
            }
            else if (count == 2)
            {
                church.SetActive(false);
                daisy.SetActive(true);
                startTime = Time.time;
                count++;
            }
            else if (count == 3)
            {
                daisy.SetActive(false);
                velvet.SetActive(true);
                startTime = Time.time;
                count++;
            }
            else if (count == 4)
            {
                velvet.SetActive(false);
                red.SetActive(true);
                startTime = Time.time;
                count++;
            }
            else if (count == 5 && again == 0)
            {
                red.SetActive(false);
                face.SetActive(true);
                again = 1;
                count = 0;
                startTime = Time.time;
            }
        }
    }
}
