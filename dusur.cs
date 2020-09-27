using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusur : MonoBehaviour
{
    [SerializeField]
    GameObject[] rastgele;
    [SerializeField]
    int k;
    void Awake()
    {
        while (k < 106)
        {
            rastgele = GameObject.FindGameObjectsWithTag("Delik");
            k++;
        }
        
    }
    void OnCollisionEnter(Collision carpisan)
    {
        if(carpisan.gameObject.tag=="Top")
        {
            int herhangi = Random.Range(0, rastgele.Length);
            Debug.Log(herhangi);
            if (rastgele[herhangi].transform.name != this.transform.name)
            {
                
                carpisan.gameObject.transform.position = rastgele[herhangi].transform.position;
            }
            Debug.Log("Merve");
        }
    }
}
