using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchingAnimals : MonoBehaviour {

    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "jjn" && other.name == "dfd")
        {
            Destroy(gameObject);
            Destroy(other);
            score++;
        }
        else if (gameObject.name == "jjn" && other.name == "dfd")
        {
            Destroy(gameObject);
            Destroy(other);
            score++;
        }
        else if (gameObject.name == "jjn" && other.name == "dfd")
        {
            Destroy(gameObject);
            Destroy(other);
            score++;
        }
        else
        {
            Destroy(gameObject);
            Destroy(other);
        }
    }
}
