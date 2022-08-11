using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataTransmitter : MonoBehaviour
{

    [SerializeField] private EnemyHealtController enemyHealtController;
    [SerializeField] private EnemyParticleController enemyParticleController;



    public void EnemyTakesDamage()
    {
        enemyHealtController.EnemyTakesDamage();
    }



    public int GetEnemyHealt()
    {
        return enemyHealtController.enemyHealt;
    }



    public void DeathParticleEffectActive()
    {
        enemyParticleController.DeathParticleEffectActive();
    }
}
