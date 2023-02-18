using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vremta : MonoBehaviour
{
    private float time = 2;

    public float TimeBanka(float size)
    {
        return size * time;
    }
}
