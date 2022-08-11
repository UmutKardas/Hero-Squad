using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRangeController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private BulletSpawnController bulletSpawnController;
    public Transform selectedEnemy;
    public bool inRange = false;



    private void Update()
    {
        inRange = false;
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            selectedEnemy = other.gameObject.transform;
            bulletSpawnController.CreateBullet();
            playerDataTransmitter.SetPlayerRotate();
            inRange = true;
        }
    }
}
