using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyCounter;

    [SerializeField]
    private TextMeshProUGUI _notificationMessage;

    public int PlayerMoney { get; set; }

    private int _moneyBonus = 1;

    // upgrades cost
    private int _2xmoneyCost = 10;
    private int _4xmoneyCost = 20;

    // Upgrades save
    private int _2xMoneyboost = 0;
    private int _4xMoneyboost = 0;

    private void Update()
    {
        _moneyCounter.text = PlayerMoney.ToString() + "$";

        // save progress
        PlayerPrefs.SetInt("money", PlayerMoney);
        PlayerPrefs.SetInt("boost2xmoney", _2xMoneyboost);
        PlayerPrefs.SetInt("boost4xmoney", _4xMoneyboost);
    }

    public void On2xMoneyBuy()
    {
        if (PlayerMoney >= _2xmoneyCost && _2xMoneyboost == 0)
        {
            _moneyBonus = 2;
            _2xMoneyboost++;
            PlayerMoney -= _2xmoneyCost;
        }
        else if (PlayerMoney < _2xmoneyCost)
        {
            _notificationMessage.text = "Nie staæ ciê! Brakuje ci " + (10 - PlayerMoney) + "$";
            Invoke("OnNotificationClearGUI", 2f);
        }
    }

    public void On4xMoneyBuy()
    {
        if (PlayerMoney >= _4xmoneyCost && _2xMoneyboost == 0)
        {
            _moneyBonus = 4;
            _2xMoneyboost++;
            PlayerMoney -= 20;
        }
        else if (PlayerMoney < 10)
        {
            _notificationMessage.text = "Nie staæ ciê! Brakuje ci " + (20 - PlayerMoney) + "$";
            Invoke("OnNotificationClearGUI", 2f);
        }
    }

    public void OnClick()
    {
        PlayerMoney += 1 * _moneyBonus;
    }

    public void OnNotificationClearGUI()
    {
        _notificationMessage.text = string.Empty;
    }

    public void Awake()
    {
        PlayerMoney = PlayerPrefs.GetInt("money");
        _2xMoneyboost = PlayerPrefs.GetInt("boost2xmoney");
        _4xMoneyboost = PlayerPrefs.GetInt("boost4xmoney");
    }
}