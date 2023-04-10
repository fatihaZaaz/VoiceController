using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class ClickHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent upEvent;
    public UnityEvent downEvent;
   
   void OnMouseDown(){
    Debug.Log("down");
    downEvent?.Invoke();
   } 

   void OnMouseUp(){
    Debug.Log("up");
    upEvent?.Invoke();
   } 
}
