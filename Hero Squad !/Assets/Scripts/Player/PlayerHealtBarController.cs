using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealtBarController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Image healtBar;
    private float maxHealt = 100f;



    void Update()
    {
        SetHealtBar();
    }



    private void SetHealtBar()
    {
        healtBar.fillAmount = playerDataTransmitter.GetPlayerHealt() / maxHealt;
    }
}
