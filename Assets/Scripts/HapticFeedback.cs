using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticFeedback : MonoBehaviour
{

    [SerializeField]
    XRBaseController rightHand;


    [SerializeField]
    XRBaseController leftHand;

    private XRGrapInteractable xRGrapInteractable;

    void Awake()
    {
        xRGrapInteractable = GetComponent<xRGrapInteractable>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SendHaptic();
    }


    void SendHaptic()
    {
        if (rightHand != null)
        {
            rightHand.SendHapticImpulse(0.5f,0.5f); 
        }
        if (leftHand != null)
        {
            leftHand.SendHapticImpulse(0.5f, 0.5f);
        }
    }

    void isCubeCollision()
    {
        return xRGrapInteractable != null && xRGrapInteractable.
    }
}
