using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject _menu;

    [SerializeField]
    private GameObject _menuMainElements;

    [SerializeField]
    private GameObject _mainMenuButton;

    [SerializeField]
    private GameObject _upgradesButtons;

    public void OnMenuEnter()
    {
        _menu.SetActive(true);
    }

    public void OnMenuExit()
    {
        _menu.SetActive(false);
    }

    public void MainMenuButton()
    {
        _mainMenuButton.SetActive(false);
        _menuMainElements.SetActive(true);
        _upgradesButtons.SetActive(false);
    }

    public void OnMusicButton()
    {
        _menuMainElements.SetActive(false);
        _mainMenuButton.SetActive(true);
    }

    public void OnLotteryButton()
    {
        _menuMainElements.SetActive(false);
        _mainMenuButton.SetActive(true);
    }

    public void OnMinigamesButton()
    {
        _menuMainElements.SetActive(false);
        _mainMenuButton.SetActive(true);
    }

    public void OnUpgradesButton()
    {
        _menuMainElements.SetActive(false);
        _mainMenuButton.SetActive(true);
        _upgradesButtons.SetActive(true);
    }

    public void OnGalleryButton()
    {
        _menuMainElements.SetActive(false);
        _mainMenuButton.SetActive(true);
    }

}