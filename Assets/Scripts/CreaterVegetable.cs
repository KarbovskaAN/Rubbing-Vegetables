using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterVegetable : MonoBehaviour
{
   public GameObject Carrot;
   public GameObject Beet;
   public GameObject Cucumber;

   public GameObject[] Vegetables;

   private void Awake()
   {
      Vegetables = new []{Carrot, Beet, Cucumber};
   }

   public GameObject InstatiateVegetable()
   {
      GameObject vegetable = Instantiate(Vegetables[0]);
      return vegetable;
   }
}
