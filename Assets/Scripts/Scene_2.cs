using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Scene_2: MonoBehaviour
{
 
    //public Texture texture;
    public ParticleSystem Fire;
    public bool isSuccessed=false;

    void Start()
    {
        //获取焊接对象
        //Fire1= gameObject.GetComponent<ParticleSystem>();
    }

   
    void Update()
    {
        //点击鼠标左键之后
        if (Input.GetMouseButtonDown(0))
        {
            //创建从摄像机发射到鼠标位置的射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            //判断射线是否与游戏对象相交
            if (Physics.Raycast(ray, out hit))
            {
                //确保游戏对象为汽车零件
                if (hit.collider.tag == "Hanjie")
                {
                    //判断鼠标状态
                    if (isSuccessed==false) 
                    {
                        //触发粒子特效
                        Debug.Log("Hitted");
                        Fire.GetComponent<ParticleSystem>().Play();
                    }

                    else
                    {
                        Fire.GetComponent<ParticleSystem>().Stop();
                    };
                }
            }
        }
    }

    
    

    //准心系统
    /*void OnGUI()
    {
        //计算准心贴图的坐标
        Rect rect = new Rect(Input.mousePosition.x - (texture.width >> 1),
                    Screen.height - Input.mousePosition.y - (texture.height >> 1), texture.width, texture.height);
        //绘制准心贴图
        GUI.DrawTexture(rect, texture);
    }*/


}
