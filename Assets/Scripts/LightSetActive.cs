using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class LightSetActive : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(false);
    }
}

