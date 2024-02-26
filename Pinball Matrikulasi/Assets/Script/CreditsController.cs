using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour
{
    public Button mainMenuButton;
    public Button exitButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainGame);

        exitButton.onClick.AddListener(ExitGame);
    }

    public void MainGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}