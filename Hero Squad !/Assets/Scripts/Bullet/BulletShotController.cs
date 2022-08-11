using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShotController : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    private Vector3 bulletVectorPosition;



    private void Start()
    {
        playerDataTransmitter = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDataTransmitter>();
    }



    void Update()
    {
        SetBulletShot();
    }



    private void SetBulletShot()
    {
        if (playerDataTransmitter.GetSelectedEnemy())
        {
            bulletVectorPosition = Vector3.MoveTowards(transform.position, playerDataTransmitter.GetSelectedEnemy().position, movementSpeed * Time.deltaTime);
            transform.position = bulletVectorPosition;

        }
    }
}
