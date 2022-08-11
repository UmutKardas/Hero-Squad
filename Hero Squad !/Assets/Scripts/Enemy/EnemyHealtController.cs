using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealtController : MonoBehaviour
{

    [SerializeField] private EnemyDataTransmitter enemyDataTransmitter;
    [SerializeField] private GameObject moneyGameobject;
    private EnemyCountController enemyCountController;
    public int enemyHealt;



    private void Start()
    {
        enemyCountController = GameObject.FindGameObjectWithTag("EnemyCount").GetComponent<EnemyCountController>();
    }



    void Update()
    {
        SetEnemyDead();
    }



    private void SetEnemyDead()
    {
        if (enemyHealt <= 0)
        {
            enemyCountController.enemyCount--;
            moneyGameobject.transform.parent = null;
            moneyGameobject.SetActive(true);
            enemyDataTransmitter.DeathParticleEffectActive();
            Destroy(gameObject);
        }
    }



    public void EnemyTakesDamage()
    {
        enemyHealt--;
    }
}
