using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Bootstrap : MonoBehaviour
{
    private Move _move;
    private Rubbing _rubbing;
    private void Start()
    {
        _move = GetComponent<Move>();
        _rubbing = GetComponent<Rubbing>();
        
        _move.AppearanceMove();
    }

    private void Update()
    {
        _move.VerticalMove();
    }
}
