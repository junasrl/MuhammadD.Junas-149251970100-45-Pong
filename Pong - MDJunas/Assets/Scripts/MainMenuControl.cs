using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Muhammad Destamal Junas - 149251970100-45");
    }

    public void OpenAuthor()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Created by Muhammad Destamal Junas - 149251970100-45");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
