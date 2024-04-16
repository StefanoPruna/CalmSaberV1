using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L_Saber : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;
    public AudioSource SwordAudio;
    //[field: SerializeField] public GameObject LeftController { get; private set; }
    [field: SerializeField] public GameObject EffectOnDestroyPrefab { get; private set; }


    //var maskHand = OVRInput.Controller.LTouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Movement of the Saber to 130 degrees to cut the cube and destroy it when hit it
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            //Here is when the Saber is from up of 130 to down towards the cube 
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
               //if (LeftController)
                    //Haptic vibration
                    
                //slice efx
                if (EffectOnDestroyPrefab)
                {
                    Instantiate(EffectOnDestroyPrefab, transform.position, Quaternion.identity);
                    //OVRInput.SetControllerVibration(.3f, 0.3f, OVRInput.Controller.LTouch);
                }
                    
                //remove object
                Destroy(hit.transform.gameObject);
                //play sound
                SwordAudio.Play();
            }
        }

        previousPos = transform.position;
    }
}
