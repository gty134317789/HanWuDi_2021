using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//批量注释 ctrl+k+c
public class Panel_Set : MonoBehaviour
{
    //void start()
    // {
    //gameobject.setactive(true);
    //gameobject obj = gameobject.find("/canvas/image");
    //obj.active=true;
    //}
    GameObject m_obj;

    void Start()
    {
        //Debug.Log("123456");
        //m_obj = GameObject.Find("Image");
        //Debug.Log(m_obj);
        //Debug.Log("123");
        //Debug.Log("987");
        //GameObject root = GameObject.Find("Canvas");
        //GameObject Image = root.transform.Find("Image").gameObject;
        GameObject root = GameObject.Find("Canvas");
        GameObject m_obj = root.transform.Find("Image").gameObject;
        //m_obj.SetActive(true);
    }

    public void Show()
    {
        GameObject root = GameObject.Find("Canvas");
        GameObject m_image = root.transform.Find("Image").gameObject;
        m_image.SetActive(true);
        GameObject m_button = root.transform.Find("Button").gameObject;
        m_button.SetActive(false);

        //if (m_obj.active == false)
        //{
        //    m_obj.SetActive(true);
        //}
        //if (m_obj.active == true) ;
        //{
        //    //gameObject.SetActive(false);
        //    m_obj.SetActive(false);
        //}
        //用if判断之后就无法执行。。。。。
    }

    public void Hide()
    {
        GameObject root = GameObject.Find("Canvas");
        GameObject m_image = root.transform.Find("Image").gameObject;
        m_image.SetActive(false);
        GameObject m_button = root.transform.Find("Button").gameObject;
        m_button.SetActive(true);
        //if (m_obj.active == false)
        //{
        //    m_obj.SetActive(true);
        //}
        //if (m_obj.active == true) ;
        //{
        //    //gameObject.SetActive(false);
        //    m_obj.SetActive(false);
        //}
        //用if判断之后就无法执行。。。。。
    }


    //public GameObject Panel;
    //public void SetTheActive()
    //{
    //    Panel.SetActive(true);
    //}

    //public void ReturnToMain()
    //{
    //    SceneManager.LoadScene(0);
    //}

    //public void ReturnToGame()
    //{
    //    Panel.SetActive(false);
    //}
}
