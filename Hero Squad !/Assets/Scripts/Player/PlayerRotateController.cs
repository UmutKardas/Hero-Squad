using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    [SerializeField] private float lerpValue;



    void Update()
    {
        SetPlayerRotate();
    }



    public void SetPlayerRotate()
    {
        if (playerDataTransmitter.GetSelectedEnemy() == false)
        {
            if (playerDataTransmitter.GetPlayerInput().x > 0f)
            {
                transform.rotation = Quaternion.Slerp
                (transform.rotation, Quaternion.Euler(0, 90f, 0), lerpValue * Time.deltaTime);
            }
            else if (playerDataTransmitter.GetPlayerInput().x < 0f)
            {
                transform.rotation = Quaternion.Slerp
               (transform.rotation, Quaternion.Euler(0, -90f, 0), lerpValue * Time.deltaTime);
            }
            else if (playerDataTransmitter.GetPlayerInput().x > 0f && playerDataTransmitter.GetPlayerInput().z > 0f)
            {
                transform.rotation = Quaternion.Slerp
               (transform.rotation, Quaternion.Euler(0, 35f, 0), lerpValue * Time.deltaTime);
            }
            else if (playerDataTransmitter.GetPlayerInput().z > 0f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), lerpValue * Time.deltaTime);
            }
            else if (playerDataTransmitter.GetPlayerInput().z < 0f)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 180f, 0), lerpValue * Time.deltaTime);
            }
        }

        else
        {

            transform.LookAt(playerDataTransmitter.GetSelectedEnemy());

        }
    }
}
