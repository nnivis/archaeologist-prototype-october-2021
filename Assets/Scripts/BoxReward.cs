using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BoxReward : MonoBehaviour, IDropHandler
{
    [HideInInspector] public static int Reward = 0;
    [SerializeField] private int PointForWin = 3;

    public void OnDrop(PointerEventData eventData)
    {
        var item = Gold.gold;
        if(item != null)
        {
            item.transform.SetParent(transform);
            Destroy(item.gameObject);
            Reward++;
        }
    }

    void Update()
    {
        if ( Reward == PointForWin)
        {
            SceneManager.LoadScene("Victory");
            Reward = 0;
        }    
    }
}
