using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberCollision : MonoBehaviour
{
    public LayerMask layerMask;
    public AudioSource Sword;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Saber")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            OVRInput.SetControllerVibration(0.5f, 0.5f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0.5f, 0.5f, OVRInput.Controller.LTouch);
            Sword.Play();
        }      

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Saber")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
            Sword.Play();
        }
        
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
