using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // movement speed variables
    float xStep;
    float zStep;
    int moveSpeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    // print instructions to console
    void printInstructions() {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move Crick about the maze using arrow keys or WASD");
        Debug.Log("Avoid the obstacles or you will die");
    }

    void movePlayer() {
        xStep = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zStep = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xStep, 0, zStep);
    }
}
