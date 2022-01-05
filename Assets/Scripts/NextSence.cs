using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;  //引用命名空间
using UnityEngine;
using UnityEngine.UI;

public class NextSence : MonoBehaviour
{
    //public Image image;

    //private Material _material;
    int a = 0;//a与书页数目相关
    public void LoadNextSence()
    {
        a++;
        if (a >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //if (image.material.color.a==1)
        //{
        //    //SceneManager.LoadScene("mainScene");//引号内为要跳转的场景名
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);	//跳转至下一场景
        //}

    }
    public void HelpLoad()
    {
        a--;
        if (a < 0)
            a = 0;
        
    }

}
