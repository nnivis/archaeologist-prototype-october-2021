using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    

    public void ReStartButton()
    {
        SceneManager.LoadScene("13.11.2021");
        ButtonLogick.NumberofLife = 0;
        BoxReward.Reward = 0;
    }
}

