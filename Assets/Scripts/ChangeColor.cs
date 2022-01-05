using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject obj_1;
    public GameObject obj_2;
    private MeshRenderer msRender_1;
    private MeshRenderer msRender_2;
    private float smooth = 0.1f;
    int a = 0;
    void Start()
    {
        //GameObject root = GameObject.Find("青铜爵/3DXY_geometry_001");
        //msRender = root.GetComponent<MeshRenderer>();
        msRender_1=obj_1.GetComponent<MeshRenderer>();
        msRender_2 = obj_2.GetComponent<MeshRenderer>();
        //msRender_1 = GetComponent<MeshRenderer>();
        //msRender_2 = GetComponent<MeshRenderer>();
        // 设置物体的初始颜色
        //msRender.material.color = Color.white;
    }

    public void StartUpate()
    {
        a = 1;
        GameObject root_1 = GameObject.Find("FatherObj");
        GameObject Camera_1 = root_1.transform.Find("摄像头1").gameObject;
        GameObject Camera_2 = root_1.transform.Find("摄像头2").gameObject;
        if(Camera_1.active==true&&Camera_2.active==false)
        {
            a = 1;
        }
        if (Camera_2.active == true && Camera_1.active == false)
        {
            a = 2;
        }

    }

    void Update()
    {
        // 通过线性插值的方式来逐渐改变物体的颜色
        if(a==1)
        {
            msRender_1.material.color = Color.Lerp(msRender_1.material.color, Color.red, smooth * Time.deltaTime);
        }
        if(a==2)
        {
            msRender_2.material.color = Color.Lerp(msRender_2.material.color, Color.red, smooth * Time.deltaTime);
        }
    }
}