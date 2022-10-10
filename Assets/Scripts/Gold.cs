using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;


public class Gold : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{

    public static Gold gold;
    private Vector3 startPosition;
    private Transform startPerent;


    public void OnBeginDrag(PointerEventData eventData)
    {
        gold = this;
        startPosition = transform.position;
        startPerent = transform.parent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gold = null;
        if (startPerent = transform.parent)
            transform.position = startPosition;
        else
            transform.position = Vector3.zero;       
    }
}