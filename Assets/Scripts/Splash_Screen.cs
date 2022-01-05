using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class Splash_Screen : MonoBehaviour
{
    //创建一个动画对象
    public Animator transition;//注意不要写成animation

    public float transitionTime = 1f;//设置时间

    public void ChangeTheSence()
    {

        StartCoroutine(LoadLevel(1));//参数只能为int

    }
    //创建携程播放动画
    IEnumerator LoadLevel(int levelIndex)
    {

        //播放相应动画
        transition.SetTrigger("Start");


        //等待
        yield return new WaitForSeconds(transitionTime);//停止这个携程等待一段时间后继续
        //加载新场景

        SceneManager.LoadScene(levelIndex);
    }
    public void ChangeTheSence_1()
    {

        SceneManager.LoadScene(1);
    }

}

