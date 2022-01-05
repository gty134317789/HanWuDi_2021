using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mousespeed=100;

    //public Transform player;

    private float xmove;

    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float x, y;
        x = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;
        xmove = xmove - y;
        xmove = Mathf.Clamp(xmove, -90, 90);

        this.transform.localRotation = Quaternion.Euler(xmove, 0, 0);

        //bplayer.Rotate(Vector3.up * x);

    }
}

