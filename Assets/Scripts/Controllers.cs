using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controllers : MonoBehaviour {

    private TextMeshPro _messages = new();


    // Start is called before the first frame update
    void Start()
    {
        //--- Get the text message component so we can write messages to it!
        _messages = GameObject.Find("DisplayMessages").GetComponent<TextMeshPro>();
        if (_messages != null)
        {
            _messages.text = "Press a Button!";
        }
        else
        {
            Debug.Log("Component not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //--- Right Controller
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            _messages.text = "A Button (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            _messages.text = "A Button (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            _messages.text = "B Button (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            _messages.text = "B Button (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            _messages.text = "Right Trigger (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            _messages.text = "Right Trigger (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            _messages.text = "Right Grip (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            _messages.text = "Right Grip (Up)";
        }

        //--- Left Controller
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            _messages.text = "X Button (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            _messages.text = "X Button (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            _messages.text = "Y Button (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.LTouch))
        {
            _messages.text = "Y Button (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            _messages.text = "Left Trigger (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            _messages.text = "Left Trigger (Up)";
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            _messages.text = "Left Grip (Down)";
        }
        else if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            _messages.text = "Left Grip (Up)";
        }
    }
}