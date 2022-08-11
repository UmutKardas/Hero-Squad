using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovementController : MonoBehaviour
{

    [SerializeField] private Transform helicopterWaitPointTransform;
    [SerializeField] private float movementSpeed;
    private Vector3 helicopterVectorPosition;



    void Update()
    {
        SetHelicopterMovement();
    }



    private void SetHelicopterMovement()
    {
        helicopterVectorPosition = Vector3.MoveTowards(transform.position, helicopterWaitPointTransform.position, movementSpeed * Time.deltaTime);
        transform.position = helicopterVectorPosition;
    }
}
