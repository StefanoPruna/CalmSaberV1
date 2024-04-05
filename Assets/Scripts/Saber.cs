using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Saber : MonoBehaviour
{
    [field: SerializeField]
    public LayerMask layer;

    [field: SerializeField]
    private Vector3 previousPos;

    [field: SerializeField]
    public AudioSource Sword;

   // [field: SerializeField]
   // public XRBaseController HandController;

    [field: SerializeField] public GameObject EffectOnDestroyPrefab { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //Movement of the Saber to 130 degrees to cut the cube and destroy it when hit it
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            //Here is when the Saber is from up of 130 to down towards the cube 
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
                if (EffectOnDestroyPrefab)
                    Instantiate(EffectOnDestroyPrefab, transform.position, Quaternion.identity);

                Destroy(hit.transform.gameObject);
              /*  if (HandController != null)
                {
                    HandController.SendHapticImpulse(0.5f, 0.5f);
                }*/
                Sword.Play();
            }                
        }

        previousPos = transform.position;
    }

    void onCollisionHaptic(Collision c)
    {

    }
}
