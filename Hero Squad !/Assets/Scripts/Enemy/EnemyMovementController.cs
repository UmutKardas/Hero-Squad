using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    private Transform playerTransform;
    private Vector3 enemyVectorPosition;



    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    void Update()
    {
        SetEnemyMovement();
    }



    private void SetEnemyMovement()
    {
        enemyVectorPosition = Vector3.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
        transform.position = enemyVectorPosition;
    }
}
