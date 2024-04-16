using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberCollision : MonoBehaviour
{
    public AudioSource Sword;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {        
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Saber")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(1f, 1f, OVRInput.Controller.LTouch);
            Sword.Play();
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
