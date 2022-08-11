using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealtBarController : MonoBehaviour
{

    [SerializeField] private EnemyDataTransmitter enemyDataTransmitter;
    [SerializeField] private Image healtBar;
    private float maxHealt = 3f;



    void Update()
    {
        SetHealtBar();
    }



    private void SetHealtBar()
    {
        healtBar.fillAmount = enemyDataTransmitter.GetEnemyHealt() / maxHealt;
    }
}
