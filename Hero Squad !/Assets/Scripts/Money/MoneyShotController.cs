using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyShotController : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    [SerializeField] private float movementSpeed;
    private Vector3 moneyVectorPosition;



    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    void Update()
    {
        SetMoneyShot();
    }



    private void SetMoneyShot()
    {
        moneyVectorPosition = Vector3.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
        transform.position = moneyVectorPosition;
    }
}
