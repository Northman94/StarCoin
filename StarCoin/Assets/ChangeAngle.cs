using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngle : MonoBehaviour 
{
    float rotationSpeed = 100f;

    private void OnMouseDrag()
    {
        float rotate_Y = Input.GetAxis("Mouse Y") * rotationSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.forward, rotate_Y);
    }




    #region Movement
    /*
    private float distanse = 10f;


    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanse);

        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
    */
    #endregion

}
