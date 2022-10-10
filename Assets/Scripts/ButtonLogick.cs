using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ButtonLogick : MonoBehaviour
{
    [HideInInspector] public static int NumberofLife = 0;
    [SerializeField] private int Life = 20;

    public Text LifeText;
    public Text RewardText;


    void Update()
    {

        int temp = Life - NumberofLife;
        int temp_1 = BoxReward.Reward;
        LifeText.text = temp.ToString();
        RewardText.text = temp_1.ToString();
        EndGame();
    }
    public void EndGame()
    {
        if ( NumberofLife == Life)
        {
            SceneManager.LoadScene("GameOver");
            BoxReward.Reward = 0;
            NumberofLife = 0;
        }
    }
    
}
