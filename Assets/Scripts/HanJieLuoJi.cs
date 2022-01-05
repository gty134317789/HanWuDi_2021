using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HanJieLuoJi : MonoBehaviour
{
    DateTime startTime;
    DateTime startSpan;
    DateTime nowSpan;

    //定义焊点
    public GameObject HanDian_1;
    public GameObject HanDian_2;

    float t1;
    float t2;


    //定义焊接特效
    public ParticleSystem Particle_1;
    public ParticleSystem Particle_2;


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

                    //获取焊接初始时间
                    startTime = DateTime.Now;


                    //确认焊点
                    HanDian_1.GetComponent<GameObject>();
                    HanDian_2.GetComponent<GameObject>();

                    //确认粒子
                    Particle_1.GetComponent<ParticleSystem>().Play();
                    Particle_2.GetComponent<ParticleSystem>().Play();


                }
            }
            t1 = Time.fixedTime;//一直在变化的时间，2s,3s.....

        }
        if (Input.GetMouseButtonUp(0))
        {
            //获取焊接结束时间
            DateTime curtimer = DateTime.Now;

            //定义间隔时间变量
            float timer = GetSubSeconds(startTime, curtimer);
            Debug.Log(timer);

            //销毁焊点
            if (timer >= 1 && timer <= 2)
            {
                Debug.Log("焊接成功");
                //销毁焊点
                Destroy(HanDian_1);
                Destroy(HanDian_2);
                //销毁错误信息
                GameObject root = GameObject.Find("Canvas");
                GameObject ErroerMassage = root.transform.Find("ErrorMessage").gameObject;
                ErroerMassage.SetActive(false);
                //使鼠标恢复正常
                Cursor.visible = true;
                GameObject root_1 = GameObject.Find("FatherObj");
                GameObject ObjForMouse = root_1.transform.Find("ObjForMouse").gameObject;
                ObjForMouse.SetActive(false);

                //显示跳转按钮
                GameObject Next_camera = root.transform.Find("Next_camera").gameObject;
                Next_camera.SetActive(true);

                //GameObject root_1 = GameObject.Find("FatherObj");
                GameObject obj = root_1.transform.Find("管理1").gameObject;
                obj.SetActive(false);
                GameObject obj_2 = root_1.transform.Find("管理2").gameObject;
                obj_2.SetActive(false);
            }
            else
            {
                t1 = Time.fixedTime;
                GameObject root = GameObject.Find("Canvas");
                GameObject ErroerMassage = root.transform.Find("ErrorMessage").gameObject;
                ErroerMassage.SetActive(true);

            }
            //关闭粒子
            Particle_1.GetComponent<ParticleSystem>().Stop();
            Particle_2.GetComponent<ParticleSystem>().Stop();



        }


    }


    public int GetSubSeconds(DateTime startTimer, DateTime endTimer)
    {
        //计算间隔时间
        TimeSpan startSpan = new TimeSpan(startTimer.Ticks);
        TimeSpan nowSpan = new TimeSpan(endTimer.Ticks);
        TimeSpan subTimer = nowSpan.Subtract(startSpan).Duration();

        //返回间隔秒数
        return subTimer.Seconds;
    }


}