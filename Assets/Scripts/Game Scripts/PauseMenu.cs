using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject _pauseCanvas;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            _pauseCanvas.SetActive(true);

    }

    public void ResumeButton()
    {
        _pauseCanvas.SetActive(false);
    }

    public void OnExitMenuButton()
    {
        SceneManager.LoadScene(0);
    }

}