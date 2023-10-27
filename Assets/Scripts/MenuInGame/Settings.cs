using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Settings : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingsWindow;

    [SerializeField]
    private GameObject _pauseMenu;

    [SerializeField]
    private Slider _musicSlider;

    [SerializeField]
    private TextMeshProUGUI _music;

    [SerializeField]
    private AudioSource _audioSource;

    public void OnSettingsOpened()
    {
        _pauseMenu.SetActive(false);
        _settingsWindow.SetActive(true);
    }

    public void OnExitSettingsButton()
    {
        _settingsWindow.SetActive(false);
        _pauseMenu.SetActive(true);
    }

    private void Update()
    {
        _music.text = Mathf.Round(_musicSlider.value * 100) + "%";
        _audioSource.volume = _musicSlider.value;
    }

    private void Awake()
    {
        _musicSlider.value = PlayerPrefs.GetFloat("musicslider");
    }

    public void OnSliderChanged()
    {
        PlayerPrefs.SetFloat("musicslider", _musicSlider.value);
    }
}
