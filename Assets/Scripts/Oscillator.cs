using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] float amplitude = 10;
    [SerializeField] float speed = 1f;
    
    public Vector3 startPosition;
    public Vector3 currentPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Debug.Log(gameObject.name + " position: " + startPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;

        if (currentPosition.z >= (startPosition.z + amplitude)) {
            speed = -speed;
        } else if (currentPosition.z <= (startPosition.z - amplitude)) {
            speed = -speed;
        }

        gameObject.transform.Translate(0, 0, speed);
    }
}
