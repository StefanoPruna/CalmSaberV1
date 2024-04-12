using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    [field: SerializeField] public GameObject EffectOnDestroyPrefab { get; private set; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EffectOnDestroyPrefab)
            Instantiate(EffectOnDestroyPrefab, transform.position, Quaternion.identity);
    }
}
