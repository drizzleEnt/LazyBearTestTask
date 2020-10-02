using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SpaceBarManager : MonoBehaviour
{
    [SerializeField] private UnityEvent _clickSpaceBar;
    [SerializeField] private UnityEvent _clicksSpaceBar;

    private int _count = 0;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _count < 1)
        {
            _clickSpaceBar?.Invoke();
            _count++;
        }
        if(Input.GetKeyDown(KeyCode.Space) && _count >= 1)
        {
            _clicksSpaceBar?.Invoke();
        }
    }
}
