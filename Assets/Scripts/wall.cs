
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class wall : MonoBehaviour
{
    public Image image;
    void Start()
    {
        //GameObject root = GameObject.Find("Canvas");
        //GameObject image = root.transform.Find("Image").gameObject;

    }

    void Update()
    {
        var r = image.color.r;
        var g = image.color.g;
        var b = image.color.b;
        //Time.time / 5f
        var alpha = Mathf.PingPong(Time.time , 0);
        image.color = new Color(r, g, b, alpha);
    }
}
