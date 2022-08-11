using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticleController : MonoBehaviour
{

    [SerializeField] private ParticleSystem deathParticle;
    [SerializeField] private GameObject enemyGameobject;
    [SerializeField] private GameObject particleGameobject;



    void Update()
    {
        FallowEnemyPosition();
    }



    private void FallowEnemyPosition()
    {
        transform.localPosition = enemyGameobject.transform.position;
    }



    public void DeathParticleEffectActive()
    {
        particleGameobject.transform.parent = null;
        deathParticle.Play();
    }
}
