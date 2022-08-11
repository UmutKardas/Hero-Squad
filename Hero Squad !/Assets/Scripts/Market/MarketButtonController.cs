using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketButtonController : MonoBehaviour
{

    [SerializeField] private MoneyCountController moneyCountController;
    private PlayerHealtController playerHealtController;



    private void Start()
    {
        playerHealtController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealtController>();
    }



    public void CheapHealtButton()
    {
        if (moneyCountController.moneyCount >= 300 && playerHealtController.playerHealt <= 90)
        {
            playerHealtController.playerHealt += 10;
            moneyCountController.moneyCount -= 300;
        }
    }



    public void ExpensiveHealtButton()
    {
        if (moneyCountController.moneyCount >= 2100 && playerHealtController.playerHealt <= 50)
        {
            playerHealtController.playerHealt += 50;
            moneyCountController.moneyCount -= 2100;
        }
    }
}
