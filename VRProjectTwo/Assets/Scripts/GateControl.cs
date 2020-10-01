using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour
{
    public string whichTag; // reference to the tag on the boxes
    public GameObject currentGate; // reference to the current gate

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when the player places the right block on the pedestal, destroy the wall
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(whichTag))
        {
            Destroy(currentGate);
        }
    }
}
