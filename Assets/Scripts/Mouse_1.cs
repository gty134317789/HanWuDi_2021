using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_1 : MonoBehaviour
{
    /// 要更换的图片
    /// 
    public Texture mouseImage;
    public Texture mouseImage_2;
    /// 
    /// 记录鼠标的位置
    /// 
    private Vector3 msPos;
    // Use this for initialization
    void Start()
    {
        //把鼠标隐藏掉
        //Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        //Cursor.visible = true;
        Cursor.visible = false;
        msPos = Input.mousePosition;
        GUI.DrawTexture(new Rect(msPos.x-11, Screen.height - msPos.y-38 , 100, 100), mouseImage);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("click");
        //    msPos = Input.mousePosition;
        //    GUI.DrawTexture(new Rect(msPos.x - 8, Screen.height - msPos.y - 19, 100, 100), mouseImage_2);
        //    mouseImage = mouseImage_2;
        //}
    }



}
