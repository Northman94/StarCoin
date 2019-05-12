using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationPointMovement : MonoBehaviour 
{
    private void FixedUpdate()
    {
        transform.position = new Vector3(Random.Range(-4.5f, 5f), 7f, 7f); // ( X ) / Y / Z
    }
}
