using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HanJie_Main : MonoBehaviour
{
    DateTime startTime;
    DateTime startSpan;
    DateTime nowSpan;
    private GameObject HanDian;
    private ParticleSystem Particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
                //确保游戏对象为焊点
                if (hit.collider.tag == "焊点")
                {
                    GameObject HanDian = gameObject.GetComponent<GameObject>();
                    Particle = gameObject.GetComponent<ParticleSystem>();
                    //确认焊点和粒子
                    GetHanDianAndParticle();
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            DestroyHanDian();
        }


    }


    public int GetSubSeconds(DateTime startTimer, DateTime endTimer)
    {
        TimeSpan startSpan = new TimeSpan(startTimer.Ticks);
        TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);
        TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

        //返回间隔秒数
        return subTimer.Seconds;
    }

    //获取焊点并触发粒子
    void GetHanDianAndParticle() 
    {
        //GameObject HanDian = gameObject.GetComponent<GameObject>();
        //Particle = gameObject.GetComponent<ParticleSystem>();
        Particle.GetComponent<ParticleSystem>().Play();
    }

    //销毁焊点函数
    void DestroyHanDian()
    {
        DateTime curtimer = DateTime.Now;
        float timer = GetSubSeconds(startTime, curtimer);
        Debug.Log(timer);
        if (timer >= 0 && timer <= 2)
        {
            Debug.Log("焊接成功");
            //销毁焊点
            Destroy(HanDian);
        }
        else
        {
            Debug.Log("这里应该弹出一个弹框");
        }
        //手动关闭粒子
        //ParticleSystem Particle = GetComponent<ParticleSystem>();
        Particle.GetComponent<ParticleSystem>().Stop();
    }
}
