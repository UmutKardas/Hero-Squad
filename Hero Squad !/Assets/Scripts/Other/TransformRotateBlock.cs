using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotateBlock : MonoBehaviour
{

    void Update()
    {
        SetRotateBlock();
    }



    private void SetRotateBlock()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
