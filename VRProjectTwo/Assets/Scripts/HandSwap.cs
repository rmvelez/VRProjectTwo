using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandSwap : MonoBehaviour
{
    public GameObject XRLeftGrab; // the left hand controller used for grabing
    public GameObject XRRightGrab; // the right hand controller used for grabing
    public GameObject XRLeftWarp; // the left hand controller used for warping
    public GameObject XRRightWarp; // the right hand controller used for warping

    private bool leftHandWarp; // these bools are used to determine which hand is active
    private bool rightHandWarp;
    //private XRController xRController;

    // Start is called before the first frame update
    void Start()
    {
        // when the game starts, the player will have the grab hands active, but the teleport hands inactive
        XRLeftGrab.SetActive(true);
        XRRightGrab.SetActive(true);
        XRLeftWarp.SetActive(false);
        XRRightWarp.SetActive(false);

        //xRController = XRLeftGrab.GetComponent<XRController>();

        leftHandWarp = false;
        rightHandWarp = false;
    }

    // Update is called once per frame
    void Update()
    {
        // when the player presses and holds the X button, the raycast on the left hand is activated
        if(Input.GetKeyDown(KeyCode.Joystick1Button2) && leftHandWarp == false)
        {
            leftHandWarp = true;
            XRLeftGrab.SetActive(false);
            XRLeftWarp.SetActive(true);
        }
        // when released, the raycast is disabled
        else if (Input.GetKeyUp(KeyCode.Joystick1Button2) && leftHandWarp == true)
        {
            leftHandWarp = false;
            XRLeftGrab.SetActive(true);
            XRLeftWarp.SetActive(false);
        }
        // when the player presses and holds the A button, the raycast is activated
        else if (Input.GetKeyDown(KeyCode.Joystick2Button0) && rightHandWarp == false)
        {
            rightHandWarp = true;
            XRRightGrab.SetActive(false);
            XRRightWarp.SetActive(true);
        }
        // when released, the raycast is disabled
        else if (Input.GetKeyUp(KeyCode.Joystick2Button0) && rightHandWarp == true)
        {
            rightHandWarp = false;
            XRRightGrab.SetActive(true);
            XRRightWarp.SetActive(false);
        }
    }
}
