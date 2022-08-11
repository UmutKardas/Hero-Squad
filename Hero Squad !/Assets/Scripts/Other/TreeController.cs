using UnityEngine;
using DG.Tweening;

public class TreeController : MonoBehaviour
{

    [SerializeField] private Material treeMaterial;
    [SerializeField] private Color opacityOrjinalColor;
    [SerializeField] private Color opacityColor;
    private Transform playerTransform;



    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }



    void Update()
    {
        CheckPlayerPosition();
    }



    private void CheckPlayerPosition()
    {
        if (playerTransform.position.z > transform.position.z)
        {
            treeMaterial.DOColor(opacityColor, 2);
        }

        else
        {
            treeMaterial.DOColor(opacityOrjinalColor, 2);
        }
    }
}
