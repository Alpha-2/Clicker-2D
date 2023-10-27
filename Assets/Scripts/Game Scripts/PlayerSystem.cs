using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using System.Security.Cryptography;

public class PlayerSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyCounter;

    public int PlayerMoney {  get; set; }

    private void Update()
    {
        PlayerPrefs.SetInt("money", PlayerMoney);
        _moneyCounter.text = PlayerMoney.ToString();
    }

    public void SaveMoney()
    {
        PlayerPrefs.SetInt("money", PlayerMoney);
    }

    public void OnClick()
    {
        PlayerMoney += 1;
    }

    public void Start()
    {
        PlayerMoney = PlayerPrefs.GetInt("money");
    }
}