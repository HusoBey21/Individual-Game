using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sayici : MonoBehaviour
{
    public Text metin; //Metin tutulur.
    public int sayac;
    public carpisma saglik;
   
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject.tag=="Silindir")
        {
            saglik = carpisan.gameObject.GetComponent<carpisma>();
            this.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
            if(saglik.saglik <=0)
            {
                sayac++;
            }
            metin.text = "Cylinder defeated: " + sayac.ToString();
        }
    }
}
