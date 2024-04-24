using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberV2 : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;
    public AudioSource Sword;
    public string controllerName;

    [field: SerializeField] public GameObject EffectOnDestroyPrefab { get; private set; }

    // Start is called before the first frame update
    void Start()
    {       
        Debug.Log(layer.value.ToString());
    }

    // Update is called once per frame
    void Update()
    {
       
        RaycastHit hit;
        //Movement of the Saber to 130 degrees to cut the cube and destroy it when hit it
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            
                if (EffectOnDestroyPrefab)
                {
                    Instantiate(EffectOnDestroyPrefab, transform.position, Quaternion.identity); 

                    if(controllerName == "Left")
                        OVRInput.SetControllerVibration(0.5f, 0.5f, OVRInput.Controller.LTouch);    
                    
                    if (controllerName == "Right")
                        OVRInput.SetControllerVibration(0.5f, 0.5f, OVRInput.Controller.RTouch);                   
                }

                Destroy(hit.transform.gameObject);
                Sword.Play();         

        }
                
     

        previousPos = transform.position;
    }


   



}
