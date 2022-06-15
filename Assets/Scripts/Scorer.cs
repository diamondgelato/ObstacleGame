using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);

        // if (!(other.gameObject.CompareTag("Hit"))) {
        if (other.gameObject.tag != "Hit") {
            score++;
            Debug.Log("Number of collisions: " + score);
        }
    }
}
