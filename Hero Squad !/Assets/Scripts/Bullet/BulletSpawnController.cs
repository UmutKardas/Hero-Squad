using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnController : MonoBehaviour
{

    [SerializeField] private Transform bulletSpawnTransform;
    [SerializeField] private GameObject bulletPrefab;
    private PlayerDataTransmitter playerDataTransmitter;
    private float currentTime;
    public float time;



    private void Start()
    {
        playerDataTransmitter = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataTransmitter>();
    }



    public void CreateBullet()
    {
        if (currentTime <= 0)
        {
            currentTime = time;
            Instantiate(bulletPrefab, bulletSpawnTransform.position, Quaternion.identity);
        }

        else
        {
            currentTime -= Time.deltaTime;
        }
    }

}
