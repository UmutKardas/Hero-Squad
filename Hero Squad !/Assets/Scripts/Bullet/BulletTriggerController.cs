using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTriggerController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Enemy") && !other.gameObject.CompareTag("Range"))
        {
            gameObject.SetActive(false);
        }
    }

}
