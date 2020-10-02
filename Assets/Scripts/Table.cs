using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    [SerializeField] private LayerMask _whatIsVisitor;

    private float _radius = 0.1f;
    
    public bool _isOccupated = false;

    private void Update()
    {
       _isOccupated = Physics2D.OverlapCircle(transform.position, _radius , _whatIsVisitor);
    }

}
