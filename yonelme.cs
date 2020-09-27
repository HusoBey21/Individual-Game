using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonelme : MonoBehaviour
{
   void OnCollisionEnter(Collision carpisan)
    {
        if(carpisan.gameObject.tag=="Engelsiz")
        {
            this.GetComponent<CharacterController>().SimpleMove(Vector3.back * 5f);
            Debug.Log("Hüseyin");
        }
    }
}
