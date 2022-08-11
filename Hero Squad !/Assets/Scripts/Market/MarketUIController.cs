using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketUIController : MonoBehaviour
{

    [SerializeField] private GameObject marketUIObject;



    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            marketUIObject.SetActive(true);
        }

        else
        {
            marketUIObject.SetActive(false);
        }
    }
}
