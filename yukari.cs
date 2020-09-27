using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukari : MonoBehaviour
{
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject.tag=="Küresel" || carpisan.gameObject.tag=="Top") 
        {
            carpisan.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0f, 5f, 0f) * Time.deltaTime; //Yukarı yönlü bir kuvvet uygulanacak.
            StartCoroutine(eskiyeDon(carpisan));
        }
    }

  IEnumerator eskiyeDon(Collider vurulan)
    {
        yield return new WaitForSeconds(.7f);
        if(vurulan.gameObject.tag=="Küresel" || vurulan.gameObject.tag=="Top")
        {
            vurulan.gameObject.GetComponent<Rigidbody>().velocity= new Vector3(0f, -5f, 0f) * Time.deltaTime; //Aşağı yönlü bir kuvvet uygulanacak.
        }
    }
}
