using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
     void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Friendly");
                break;
            case "Finish":
                Debug.Log("Finished");
                break;
            case "Fuel":
                Debug.Log("Fuel Collected");
                break;
            default:
                Debug.Log("You exploded");
                break;
        }
    }

}
