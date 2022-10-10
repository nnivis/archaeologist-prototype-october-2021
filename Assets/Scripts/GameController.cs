using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private int capacity; // количество €чеек


    [SerializeField] private Transform Field; // родительский объект
    public static Cell[] content; // ссылка на массив €чеек

    [HideInInspector] public Cell cell;
    private Transform Cell;

   


    void Awake()
    {
        
        content = new Cell[capacity];
        CreateCell();
                  
    }

    void CreateCell()
    {
        for (int i = 0; i < capacity; i++)
        {
            GameObject cell = Instantiate(Resources.Load<GameObject>("Cell"));

            cell.transform.SetParent(Field);
            cell.transform.localScale = Vector2.one;
            cell.name = string.Format("Cell [{0}]", i);

            if (UnityEngine.Random.Range( 0, 2) == 0)
            {
                content[i] = cell.GetComponent<Cell>();

                GameObject gold = Instantiate(Resources.Load<GameObject>("Gold"));
                gold.transform.SetParent(content[i].transform);
                gold.transform.localScale = Vector2.one;
                gold.GetComponent<Gold>();
            }
        }
    }

}
