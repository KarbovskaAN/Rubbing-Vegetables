using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Banka : MonoBehaviour
{
    [SerializeField] private float Size;
    [SerializeField] private Vremta time;
    
    public float ScaleBanka;

    private void Start()
    {
        ScaleBanka = time.TimeBanka(Size);
        Debug.Log(ScaleBanka);
    }
    
}
