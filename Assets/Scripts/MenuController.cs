using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject buttonsPanel;
    [SerializeField] private  GameObject creditPanel;
    //[SerializeField] private GameObject pausePanel;
  // [SerializeField] private GameManager gameManager;

    public void PlayGame()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void Credits()
    {
        buttonsPanel.SetActive(false);
        creditPanel.SetActive(true);
    }

  //  public void Resume()
    //{
      //  pausePanel.SetActive(false);
        //gameManager.ResumeGame();
    //}

    public void Back()
    {
        buttonsPanel.SetActive(true);
        creditPanel.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
