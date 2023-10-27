using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingsWindow;
    [SerializeField]
    private GameObject _gameTitleMenu;

    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnSettingsButton()
    {
        _gameTitleMenu.SetActive(false);
        _settingsWindow.SetActive(true);
    }

    public void OnExitButton()
    {
        Application.Quit();
    }

}
