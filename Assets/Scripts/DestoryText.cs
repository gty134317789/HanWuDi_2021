
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DestoryText : MonoBehaviour
{
    public Text obj;

    float t1;
    float t2;
    void Start()
    {

        var alpha = 0f;
        var r = obj.color.r;
        var g = obj.color.g;
        var b = obj.color.b;
        //Time.time / 5f
       
        obj.color = new Color(r, g, b, alpha);
        t1 = Time.fixedTime;//记录生成子弹当下的时刻；只调用一次，现在是1s,
    }
    void Update()
    {

        t2 = Time.fixedTime;//一直在变化的时间，2s,3s.....
        var r = obj.color.r;
        var g = obj.color.g;
        var b = obj.color.b;
        //Time.time / 5f
        var alpha = Mathf.PingPong(Time.time, 1);
        obj.color = new Color(r, g, b, alpha);
        if (t2 - t1 >= 5)
        {
            GameObject root = GameObject.Find("Canvas");
            GameObject ButNext = root.transform.Find("Next").gameObject;
            ButNext.SetActive(true);
            Destroy(this.gameObject);// 脚本建立在什么物体上，gameobject就为什么物体

        }
    }
}