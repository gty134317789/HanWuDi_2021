using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadTheGame()
    {
        Debug.Log("01");
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Debug.Log("02");
        Application.Quit();
    }

    public void ChooseTheGame()
    {
        Debug.Log("01");
        SceneManager.LoadScene(2);
    }

    public void LoadTheMain()
    {
        Debug.Log("01");
        SceneManager.LoadScene(1);
    }
}
