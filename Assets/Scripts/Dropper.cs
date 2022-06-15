using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer rend;
    Rigidbody body;
    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rend.enabled = false;
        
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time > timeToWait) && !changed) {
            rend.enabled = true;
            body.useGravity = true;
            changed = true;
            // Debug.Log(timeToWait + " secs are up");
        }
    }
}
