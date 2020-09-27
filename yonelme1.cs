using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonelme1 : MonoBehaviour
{
   void OnCollisionEnter(Collision carpisan)
    {
        if(carpisan.gameObject.tag=="Engelsiz")
        {
            carpisan.gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.back * 5f);
            Debug.Log("Hüseyin");
        }
    }
}
