using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class carpisma : MonoBehaviour
{
    public float saglik = 100f;
    

    public void canYitir(float hasar)
    {
        saglik = saglik - hasar;
        if(saglik<=0)
        {
            saglik = 0;
            Destroy(gameObject);
           
        }
        
    }
}
