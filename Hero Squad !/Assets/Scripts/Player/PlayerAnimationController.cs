using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    public Animator playerAnimator;



    void Update()
    {
        SetRunAnimation();
        SetAttackAnimation();
    }



    private void SetRunAnimation()
    {
        if (Mathf.Abs(playerDataTransmitter.GetPlayerInput().x) > 0f || Mathf.Abs(playerDataTransmitter.GetPlayerInput().z) > 0f)
        {
            playerAnimator.SetBool("Running", true);
        }

        else
        {
            playerAnimator.SetBool("Running", false);
        }
    }



    private void SetAttackAnimation()
    {
        if (playerDataTransmitter.GetSelectedEnemy() && (playerDataTransmitter.GetPlayerInput().x == 0) && (playerDataTransmitter.GetPlayerInput().y == 0))
        {
            playerAnimator.SetBool("Attack", true);
        }

        else
        {
            playerAnimator.SetBool("Attack", false);
        }
    }
}
