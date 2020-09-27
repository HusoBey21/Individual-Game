using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vurucu : MonoBehaviour
{
    public float surat;
    public Transform hedef;
    
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject.tag=="Top")
        {
            
            carpisan.gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * Time.deltaTime * surat;  //Hız ayarlandı.
            StartCoroutine(besSaniye(carpisan));
            Debug.Log("Damla");
        }
       
    }
    IEnumerator besSaniye(Collider carpisan)
    {
        yield return new WaitForSeconds(5f);
        
        carpisan.gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * Time.deltaTime * surat;
        
    }
}
