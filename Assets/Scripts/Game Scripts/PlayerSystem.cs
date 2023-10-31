using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _moneyCounter;

    [SerializeField] 
    private GameObject _notificationGUI;

    [SerializeField]
    private TextMeshProUGUI _notificationMessage;

    public int PlayerMoney { get; set; }

    private int _moneyBonus = 1;

    // upgrades cost
    private int _2xmoneyCost = 10;
    private int _4xmoneyCost = 20;

    private int _buyingItemCostSummary;

    // Upgrades save
    private int _2xMoneyboost = 0;
    private int _4xMoneyboost = 0;

    private void Update()
    {
        _moneyCounter.text = PlayerMoney.ToString();
        _notificationMessage.text = "Nie staæ ciê! Brakuje ci " + (_buyingItemCostSummary - PlayerMoney);
        Invoke("OnNotificationGUI", 6f);


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
            _buyingItemCostSummary = _2xmoneyCost;
            _notificationGUI.SetActive(true);
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
            _buyingItemCostSummary = _4xmoneyCost;
            _notificationGUI.SetActive(true);
        }
    }

    public void OnClick()
    {
        PlayerMoney += 1 * _moneyBonus;
    }

    public bool IsBuyable(int cost, int playerMoney)
    {
        bool summary;
        
        if (cost >= playerMoney)
            summary = true;
        else
            summary = false;


        return summary;
    }

    public void OnClearNotificationGUI()
    {
        _notificationMessage.text = String.Empty;
    }

    public void Awake()
    {
        PlayerMoney = PlayerPrefs.GetInt("money");
        _2xMoneyboost = PlayerPrefs.GetInt("boost2xmoney");
        _4xMoneyboost = PlayerPrefs.GetInt("boost4xmoney");
    }
}
