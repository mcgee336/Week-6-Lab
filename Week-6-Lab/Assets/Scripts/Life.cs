using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreLife : MonoBehaviour
{
    [SerializeField] int life = 3;
    
    public void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        if (other.gameObject.tag != "Friendly")
        {
            life--;
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        if (life == 1)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (life == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (life < 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.gray;
        }
    }
}
