using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_3 : MonoBehaviour
{
    /// 要更换的图片
    /// 
    public Texture mouseImage;
    /// 
    /// 记录鼠标的位置
    /// 
    private Vector3 msPos;
    // Use this for initialization
    void Start()
    {
        //把鼠标隐藏掉
        Cursor.visible = false;
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
        GUI.DrawTexture(new Rect(msPos.x - 5, Screen.height - msPos.y - 20, 100, 100), mouseImage);
    }
}
