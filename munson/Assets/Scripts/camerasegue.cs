using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasegue : MonoBehaviour
{
    public Transform cass_0;
    public float minX, maxX;
    public float timeLerp;

    private void FixedUpdate()
    { 
        Vector3 newPosition = cass_0.position + new Vector3(0,0,-10);
        newPosition.y = 1.67f;
        newPosition = Vector3.Lerp(transform.position, newPosition, timeLerp);
        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }
}


