using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class OneButton : MonoBehaviour, IPointerClickHandler
{
   
    public OneButton Button;
    [SerializeField] private int MaxDepth = 3;


    void Update()
    {
        if (MaxDepth == 2)
            Button.GetComponent<Image>().color = Color.red;
        if (MaxDepth == 1)
            Button.GetComponent<Image>().color = Color.green;
        if (MaxDepth == 0)        
            Destroy(Button.gameObject);       
    }

    void MinusDepth()
    {
        if ( MaxDepth != 0)
        {
            MaxDepth--;
            ButtonLogick.NumberofLife++;
        }       
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        MinusDepth();
    }

}
