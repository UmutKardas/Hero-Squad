using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealtController : MonoBehaviour
{

    public int playerHealt;



    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            playerHealt = 100;
            PlayerPrefs.SetInt("healt", playerHealt);
        }

        playerHealt = PlayerPrefs.GetInt("healt");
    }



    public void SetTakenDamage()
    {
        playerHealt -= 20;
        PlayerPrefs.SetInt("healt", playerHealt);
    }
}
