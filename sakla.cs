using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sakla : MonoBehaviour
{
    void OnCollisionEnter(Collision carpisan)
    {
        if(carpisan.gameObject.tag=="Top")
        {
            Physics.IgnoreLayerCollision(10, 11, true); //Katman çarpıştırıcıları etkin.
            carpisan.gameObject.GetComponent<SphereCollider>().isTrigger = true;
            this.GetComponent<BoxCollider>().isTrigger = true;
            Debug.Log("Bağırma");

        }
    }
}
