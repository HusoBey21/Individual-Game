using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giremezsin : MonoBehaviour
{
   void OnCollisionEnter(Collision carpisma)
    {
        if(carpisma.gameObject.tag=="Küresel")
        {
            Debug.Log("İrem");
            carpisma.gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.left * 5f);
        }
    }
}
