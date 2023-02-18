using UnityEngine;

public class Rubbing : MonoBehaviour
{
    public Move Object;
    
    public float AllScaleChild;
    
    private int _childCount;
    private bool _locationCheck;
    

    public Vector3 _positionObject;
    private void Update()
    {
        RubbingObject();
        CheckRubbingResult();
    }

    public void RubbingObject()
    {
       _childCount = Object._currentObject.transform.childCount;
       _positionObject = Object._currentObject.transform.position;
       
       if (_positionObject.y <= -1.3f )
       { 
           if (_locationCheck == false)
           { 
               GameObject child = Object._currentObject.transform.GetChild(_childCount-1).gameObject; 
               float scaleChild = child.GetComponent<ScaleElement>().Scale;
               
               _positionObject.z += scaleChild;
               AllScaleChild += scaleChild;
               Object._currentObject.transform.position = _positionObject; 
               Destroy(child); 
               _childCount=-1; 
               _locationCheck = true;
                
           }
       } 
       if (_positionObject.y >= -0.7f) 
       { 
           _locationCheck = false;
       }
    }

    private void CheckRubbingResult()
    {
        if (_childCount == 1)
        {
            Debug.Log("1");
        }
        if (_childCount == 0)
        {Debug.Log("0");
        }
    }
}
