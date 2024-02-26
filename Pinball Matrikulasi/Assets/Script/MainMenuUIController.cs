using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditsButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);

        exitButton.onClick.AddListener(ExitGame);

        creditsButton.onClick.AddListener(Credits);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits_Game");
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}