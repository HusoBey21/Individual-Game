using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dokunus : MonoBehaviour
{
   
    void OnTriggerEnter(Collider carpisan)
    {
        if(carpisan.gameObject.tag=="Top")
        {


            carpisan.gameObject.transform.Translate(Vector3.left * Time.deltaTime*150f); //Topa dokununca top aşağıya uçacak ve yeniden başlamasına neden olacak.
            this.gameObject.GetComponent<carpisma>().canYitir(2f);
            Debug.Log("Ebrar");
        }

    }
}
