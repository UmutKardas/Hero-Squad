using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float movementSpeed;



    void FixedUpdate()
    {
        SetPlayerMovement();
    }



    private void SetPlayerMovement()
    {
        playerRigidbody.velocity = new Vector3(
            playerDataTransmitter.GetPlayerInput().x * movementSpeed * Time.fixedDeltaTime,
            playerRigidbody.velocity.y,
            playerDataTransmitter.GetPlayerInput().z * movementSpeed * Time.fixedDeltaTime
        );
    }
}
