using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{

    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerRangeController playerRangeController;
    [SerializeField] private PlayerRotateController playerRotateController;
    [SerializeField] private PlayerHealtController playerHealtController;



    public Vector3 GetPlayerInput()
    {
        return playerInputController.playerVector;
    }



    public Transform GetSelectedEnemy()
    {
        return playerRangeController.selectedEnemy;
    }



    public bool GetEnemyInRange()
    {
        return playerRangeController.inRange;
    }



    public void SetPlayerRotate()
    {
        playerRotateController.SetPlayerRotate();
    }



    public void SetTakenDamage()
    {
        playerHealtController.SetTakenDamage();
    }



    public int GetPlayerHealt()
    {
        return playerHealtController.playerHealt;
    }
}
