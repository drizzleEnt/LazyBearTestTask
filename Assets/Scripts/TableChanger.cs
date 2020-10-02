using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableChanger : MonoBehaviour
{
    private Visitor[] _visitors;

    private bool _isMoving = false;

    private void Start()
    {
        _visitors = FindObjectsOfType<Visitor>();
    }

    public void TablesChanger()
    {
        if (_isMoving == false)
        {
            StartCoroutine(Change());
        }

    }

    private IEnumerator Change()
    {
        
            _isMoving = true;
            float ChanceOfChange = 0.45f;

            if (Random.value < ChanceOfChange)
            {
                int rand = Random.Range(0, _visitors.Length);
                _visitors[rand].ChangeTable();
            }
        
        yield return new WaitForSeconds(1.5f);
        _isMoving = false;
    }
}
