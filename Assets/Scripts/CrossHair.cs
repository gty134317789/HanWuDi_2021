using UnityEngine;
using System.Collections;

public class CrossHair: MonoBehaviour
{
    public Texture2D texture;
    // Use this for initialization

    void Update()
    {
        //创建从摄像机到鼠标之间的射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //判断该射线是否打中游戏对象
        if (Physics.Raycast(ray ,out hit))
        {
            
        }
    }
    void OnGUI()
    {

        Rect rect = new Rect(Input.mousePosition.x - (texture.width / 2),
        Screen.height - Input.mousePosition.y - (texture.height / 2),
        texture.width, texture.height);
        GUI.DrawTexture(rect, texture);
    }
}