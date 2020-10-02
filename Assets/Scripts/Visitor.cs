using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class Visitor : MonoBehaviour
{
    [SerializeField] private int _table;

     private int _currentTable;
     private int[] _hostes = new int[6];
     private Table[] _tables;

    private Hostes _host;
    

    private void Start()
    {
        _host = FindObjectOfType<Hostes>();
        _tables = FindObjectsOfType<Table>();
        

    }
    public void MoveToTable()
    {
        for (int i = 0; i < _hostes.Length; i++)
        {
            _hostes[i] = _host._randNums[i];
        }

        _currentTable = _hostes[_table];

        transform.DOMove(_tables[_currentTable].transform.position ,2);

    }

    public void ChangeTable()
    {

        for (int i = 0; i < _tables.Length; i++)
        {
            if(_tables[i]._isOccupated == false)
            {
                _currentTable = i;
                transform.DOMove(_tables[_currentTable].transform.position, 2);
                break;
            }
        }
    }

    
}
