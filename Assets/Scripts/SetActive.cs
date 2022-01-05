using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //引用命名空间
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    //两个摄像头
    //public GameObject Camera_1;
    //public GameObject Camera_2;
    //含有焊接逻辑的空物体
    //public GameObject obj_1;
    //public GameObject obj_2;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject root_1 = GameObject.Find("FatherObj");
        GameObject Camera_1 = root_1.transform.Find("摄像头1").gameObject;
        GameObject Camera_2 = root_1.transform.Find("摄像头2").gameObject;
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
    }

    // Update is called once per frame
    public void SetButHot()
    {
        
        
    }

    //显示销毁按钮与物体
    public void SetNextAndHot()
    {
        GameObject root = GameObject.Find("Canvas");
        GameObject ButHot = root.transform.Find("hot").gameObject;
        GameObject Next = GameObject.Find("Canvas/Next");
        Next.SetActive(false);
        ButHot.SetActive(true);
    }

    public void SetCamera_2()
    {
        GameObject root_1 = GameObject.Find("FatherObj");
        GameObject Camera_1 = root_1.transform.Find("摄像头1").gameObject;
        GameObject Camera_2 = root_1.transform.Find("摄像头2").gameObject;
        if (Camera_1.active == true)
        {
            Camera_1.active = false;
            Camera_2.active = true;
            GameObject root_Can = GameObject.Find("Canvas");
            GameObject Next_camera = root_Can.transform.Find("Next_camera").gameObject;
            Next_camera.SetActive(false);
            GameObject hot = root_Can.transform.Find("hot").gameObject;
            hot.SetActive(true);

        }
        else
        {
            Camera_1.active = false;
            Camera_2.active = true;
            GameObject root_Can = GameObject.Find("Canvas");
            GameObject Next_camera = root_Can.transform.Find("Next_camera").gameObject;
            Next_camera.SetActive(false);
            //场景跳转
            SceneManager.LoadScene("关卡选择");
        }
        

    }

    public void SetToolBut()
    {
        //GameObject root_1 = GameObject.Find("FatherObj");
        //GameObject ObjForMouse = root_1.transform.Find("ObjForMouse").gameObject;
        //ObjForMouse.SetActive(true);
        GameObject root_Can = GameObject.Find("Canvas");
        GameObject Tool = root_Can.transform.Find("Tool").gameObject;
        Tool.SetActive(true);
        GameObject root = GameObject.Find("Canvas/hot");
        root.SetActive(false);
    }

    public void SetMouse()
    {
        GameObject root_1 = GameObject.Find("FatherObj");
        GameObject ObjForMouse = root_1.transform.Find("ObjForMouse").gameObject;
        ObjForMouse.SetActive(true);
        GameObject Camera_1 = root_1.transform.Find("摄像头1").gameObject;
        GameObject Camera_2 = root_1.transform.Find("摄像头2").gameObject;
        if (Camera_1.active == true)
        {
            
            GameObject obj = root_1.transform.Find("管理1").gameObject;
            obj.SetActive(true);
            Debug.Log("管理1");
        }
        else
        {
            
            GameObject obj = root_1.transform.Find("管理2").gameObject;
            obj.SetActive(true);
            Debug.Log("管理2");
        }
        GameObject root = GameObject.Find("Canvas/Tool");
        root.SetActive(false);
    }
}

