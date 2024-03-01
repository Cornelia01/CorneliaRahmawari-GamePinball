using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    public float targetPressed;
    public float targetRelease;

    private HingeJoint hinge;
    
    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring = targetPressed;
        }
        else
        {
            jointSpring.spring = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}
