using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cekimGucu : MonoBehaviour
{
    public int sayac;
   
    
    
    public void dusus()
    {

        if (transform.position.x >= 490f || transform.position.x <= -15f || transform.position.z >= 490f ||transform.position.z <= -15f)
        {
            Destroy(this.gameObject); //Yok etme yapılıyor.

            sayac++;
        }
    }
}
