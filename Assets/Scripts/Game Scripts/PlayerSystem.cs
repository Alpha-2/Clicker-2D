using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyCounter;

    [SerializeField]
    private TextMeshProUGUI _notificationMessage;

    //upgrades buttons
    [SerializeField]
    private Button _2xMoneyButton;
    [SerializeField]
    private Button _4xMoneyButton;

    // upgrades buttons text
    [SerializeField] 
    private TextMeshProUGUI _2xMoneyButtonMessage;

    [SerializeField] 
    private TextMeshProUGUI _4xMoneyButtonMessage;

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

        // upgrades buttons text
        _2xMoneyButtonMessage.text = "2x money\nboost\n(10$)";
        _4xMoneyButtonMessage.text = "4x money\nboost\n(20$)";

        // save progress
        PlayerPrefs.SetInt("money", PlayerMoney);
        PlayerPrefs.SetInt("boost2xmoney", _2xMoneyboost);
        PlayerPrefs.SetInt("boost4xmoney", _4xMoneyboost);

        // upgrades button interactable check
        if (_2xMoneyboost != 0)
        {
            _2xMoneyButton.interactable = false;
        }

        if (_4xMoneyboost != 0)
        {
            _4xMoneyButton.interactable = false;
        }
    }

    public void On2xMoneyBuy()
    {
        if (PlayerMoney >= _2xmoneyCost && _2xMoneyboost == 0)
        {
            _moneyBonus += 1;
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
        if (PlayerMoney >= _4xmoneyCost && _4xMoneyboost == 0)
        {
            _moneyBonus += 4;
            _4xMoneyboost++;
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