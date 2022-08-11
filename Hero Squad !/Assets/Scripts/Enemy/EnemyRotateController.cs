using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotateController : MonoBehaviour
{

    private Transform playerTransform;



    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    void Update()
    {
        EnemyLookAtPlayer();
    }



    private void EnemyLookAtPlayer()
    {
        transform.LookAt(playerTransform);
    }
}
