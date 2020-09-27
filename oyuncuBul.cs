using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncuBul : MonoBehaviour
{
    public Transform oyuncu;
    Vector3 sonGorulenKonum;
    RaycastHit vurus;
    void Awake()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Top").transform;
    }
    void Update()
    {

        transform.LookAt(oyuncu.position);
        if (Physics.Raycast(sonGorulenKonum,Vector3.forward,out vurus))
        {
            Debug.Log(vurus.transform.name); //Vurulan nesnenin adı
            if(vurus.transform.tag=="Küre") //Etiketi
            {
                Debug.Log("Saldir");
                
               
                sonGorulenKonum = Vector3.Lerp(transform.position, oyuncu.position, 5f * Time.deltaTime);
                transform.position = sonGorulenKonum;
            }
        }
    }

}
