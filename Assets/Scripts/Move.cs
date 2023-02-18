using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject _currentObject;
    
    [SerializeField] private DynamicJoystick _joystick;
    [SerializeField] private CreaterVegetable _createrVegetable;

    private bool currentObjectOnPosition;
    
    private float _speed = 2.8f;
    private float _scaleChild;

    private TweenerCore<Vector3, Vector3, VectorOptions> tween;
    private TweenerCore<Vector3, Vector3, VectorOptions> appearanceTween;

    public void AppearanceMove()
    {
        _currentObject = _createrVegetable.InstatiateVegetable();
        _currentObject.GetComponent<Rubbing>().Object = this;

        _currentObject.transform.position = new Vector3(0f, 1.3f, -1.5f);
        appearanceTween = _currentObject.transform.DOMove(new Vector3(0f, -1f, -1.5f), 2);
    }

    public void VerticalMove()
    {
        float joystickDirection = _joystick.Vertical;
        
        StartTap();
        UpdateTap(ref joystickDirection);
        MoveObject(joystickDirection);
        FinishTap();
    }

    private void MoveObject(float joystickDirection)
    {
        if (currentObjectOnPosition == true)
        {
            _currentObject.transform.position += new Vector3(0, joystickDirection, 0) * (_speed * Time.deltaTime);
        }
    }

    private void StartTap()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentObjectOnPosition == false)
            {
                appearanceTween.Kill();
                tween?.Kill();
                _scaleChild = _currentObject.GetComponent<Rubbing>().AllScaleChild;
                tween = _currentObject.transform.DOMove(new Vector3(0, -1f,-1f+_scaleChild),0.4f).OnComplete(CheckPosition);
                
            }
        }
    }
    
    private void UpdateTap( ref float joystickDirection)
    {
        if (_currentObject.transform.position.y >= -0.5f && joystickDirection > 0)
        {
            joystickDirection = 0;
        }

        if (_currentObject.transform.position.y <= -1.5f && joystickDirection < 0)
        {
            joystickDirection = 0;
        }
    }

    private void FinishTap()
    {
        if (Input.GetMouseButtonUp(0))
        {
            tween?.Kill();
            currentObjectOnPosition = false;
            tween = _currentObject.transform.DOMove(new Vector3(0, -1f, -1.5f), 0.4f);
        }
    }

    private void CheckPosition()
    {
        if (currentObjectOnPosition == true)
        {
            currentObjectOnPosition = false;
        }
        else
        {
            currentObjectOnPosition = true;
        }

    }
}
 