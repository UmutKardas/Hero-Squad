using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCountController : MonoBehaviour
{

    [SerializeField] private TMP_Text tMP_Text;
    public int moneyCount = 0;



    private void Start()
    {
        moneyCount = PlayerPrefs.GetInt("money");
    }



    private void Update()
    {
        SetMoneyUI();
        PlayerPrefs.SetInt("money", moneyCount);
    }



    private void SetMoneyUI()
    {
        tMP_Text.text = moneyCount + "$";
    }



    public void SetMoneyCount()
    {
        moneyCount += 100;
    }
}
