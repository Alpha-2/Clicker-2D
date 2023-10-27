using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _settingsWindow;
    [SerializeField]
    private GameObject _gameTitleMenu;

    [SerializeField]
    private Slider _musicSlider;

    [SerializeField]
    private TextMeshProUGUI _music;

    [SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private TextMeshProUGUI _VsyncTitle;

    public void OnExitSettingsButton()
    {
        _settingsWindow.SetActive(false);
        _gameTitleMenu.SetActive(true);
    }

    private void Update()
    {
        _music.text = Mathf.Round(_musicSlider.value * 100)+ "%";
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
