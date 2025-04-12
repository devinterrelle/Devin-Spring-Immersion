using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDevin : MonoBehaviour
{
    public GameObject target;

    public Vector3 positionOffset;

    // Start is called before the first frame update
    void Start()
    {
        positionOffset = transform.position - target.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
            {
            transform.position = target.transform.position + positionOffset;

        }
        else
        {
            Debug.LogWarning("Camera has no target to follow!!");
        }
    }
}
