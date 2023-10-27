using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject _exitMenuButton;

    [SerializeField]
    private GameObject _mainMenuCanvas;

    [SerializeField]
    private GameObject _mainButtons;

    [SerializeField]
    private GameObject _upgradeButtons;

    public void OnMainMenuButton()
    {
        _mainMenuCanvas.SetActive(true);
        _exitMenuButton.SetActive(true);
    }

    public void OnMainMenuButtonExit()
    {
        _mainMenuCanvas.SetActive(false);
        _exitMenuButton.SetActive(false);
    }

    public void OnUpgradesButton()
    {
        _mainButtons.SetActive(false);
        _upgradeButtons.SetActive(true);
        _exitMenuButton.SetActive(true);
    }

    public void OnUpgradesExitButtons()
    {
        _mainButtons.SetActive(true);
        _upgradeButtons.SetActive(false);
        _exitMenuButton.SetActive(true);
    }

}