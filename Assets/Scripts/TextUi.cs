using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class TextUi : MonoBehaviour
{
    [SerializeField] private GameObject _instruction;
    [SerializeField] private GameObject _carrot;
    [SerializeField] private GameObject _beet;
    [SerializeField] private GameObject _cucumber;

    private Move _vegetable;

    private void Update()
    {
        SetActiveText();
        NameVegetable(_carrot,_beet,_cucumber);
    }

    private void SetActiveText()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _instruction.SetActive(false);
        }
    }

    public void NameVegetable(GameObject carrot,GameObject beet,GameObject cucumber)
    {
        _vegetable.GetComponent<Move>()._currentObject = carrot;
        
        if (carrot)
        { 
            if (Input.GetMouseButtonDown(0))
            {
               _carrot.SetActive(false);
            }
            else
            {
                _carrot.SetActive(true);
            }
        }
        if (beet)
        { 
            if (Input.GetMouseButtonDown(0))
            {
                _beet.SetActive(false);
            }
            else
            {
                _beet.SetActive(true);
            }
        }
        if (cucumber)
        { 
            if (Input.GetMouseButtonDown(0))
            {
                _cucumber.SetActive(false);
            }
            else
            {
                _cucumber.SetActive(true);
            }
        }
    }
}
