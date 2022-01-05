using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class Scene_1:MonoBehaviour
{
    //提示信息
    public Texture texture;
    public ParticleSystem Object1; 
    public ParticleSystem Object2;
    public ParticleSystem Object3;
    public ParticleSystem Object4;
    bool Finished=false;

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
                //确保游戏对象为焊接物品
                if (hit.collider.tag == "Hanjie")
                {
                    //判断对象状态
                    if (Finished==false) 
                    {
                        SceneManager.LoadScene("游戏界面2_1");
                    }

                    else
                    {
                        //Object1.GetComponent<ParticleSystem>().Stop();
                        Object2.GetComponent<ParticleSystem>().Stop();
                        //Object3.GetComponent<ParticleSystem>().Stop();
                        //Object4.GetComponent<ParticleSystem>().Stop();
                        Finished = false;

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
