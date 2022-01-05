using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MissionChoose : MonoBehaviour
{
    public void ChooseMission_1()
    {
        SceneManager.LoadScene("古代翻书");
    }
    public void ChooseMission_2()
    {
        SceneManager.LoadScene("近代翻书");
    }

    public void ChooseMission_3()
    {
        SceneManager.LoadScene("现代翻书");
        
    }

    public void Missionchoose()
    {
        SceneManager.LoadScene("关卡选择");
        Cursor.visible = true;
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("游戏主界面");
    }
}
