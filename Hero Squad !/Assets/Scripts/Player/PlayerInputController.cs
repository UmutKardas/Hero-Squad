using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    public Vector3 playerVector;



    private void Update()
    {
        SetPlayerInput();
    }



    private void SetPlayerInput()
    {
        playerVector.x = Input.GetAxisRaw("Horizontal");
        playerVector.z = Input.GetAxisRaw("Vertical");
    }
}
