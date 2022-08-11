using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelipadController : MonoBehaviour
{
    [SerializeField] private EnemyCountController enemyCountController;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && (enemyCountController.enemyCount == 0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
