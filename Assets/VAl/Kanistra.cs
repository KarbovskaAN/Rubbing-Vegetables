using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Kanistra : MonoBehaviour
{
   private float _startsize = 100;
   private float newsize;

   [SerializeField] private Banka banka;

   private void Start()
   {
      Size();
   }

   public void Size()
   {
      newsize = _startsize - banka.ScaleBanka;
      Debug.Log(newsize);
   }

}
