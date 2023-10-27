using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGamePrompt : MonoBehaviour
{
    [SerializeField]
    private GameObject _promptCanvas;

    void Update()
    {
        if (Application.isPlaying && Input.GetKeyDown(KeyCode.Escape))
        {
            _promptCanvas.SetActive(true);
        }
    }

    public void OnPromptYes()
    {
        Application.Quit();
    }

    public void OnPromptNo()
    {
        _promptCanvas.SetActive(false);
    }
}