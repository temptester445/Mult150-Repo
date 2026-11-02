using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScriptExercise : MonoBehaviour
{
    public gameObject targetObject;
    
    
    // Start is called before the first frame update
    void Start()
    {
        string objectName = targetObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has collided with " + objectName);
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in " + objectName);
    }

    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left " + objectName);
    }
}
