using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerController : MonoBehaviour
{

    [SerializeField] private EnemyDataTransmitter enemyDataTransmitter;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            enemyDataTransmitter.EnemyTakesDamage();
            other.gameObject.SetActive(false);
        }
    }
}
