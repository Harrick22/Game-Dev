using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;

    //This will restart the active scene

    public void OnRestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnGameResumePress()
    {
       pauseUI.SetActive(false);
    }

    public void OnGameExitPress()
    {
        Application.Quit();
    }

    public void OnEnterPausePress()
    {
        pauseUI.SetActive(true);
    }
}
