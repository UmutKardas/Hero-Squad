using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private MoneyCountController moneyCountController;



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            playerDataTransmitter.SetTakenDamage();
        }


        if (other.gameObject.CompareTag("Money"))
        {
            moneyCountController.SetMoneyCount();
            other.gameObject.SetActive(false);
        }
    }
}
