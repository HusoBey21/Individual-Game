using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class yercekimi : MonoBehaviour
{
    public Text metin;
    public int sayac;
    
    cekimGucu guc;
   void Awake()
    {
        Application.targetFrameRate = 10;
    }
    
    void OnCollisionEnter(Collision carpisan)
    {
        if(carpisan.gameObject.tag=="Küresel")
        {

            this.GetComponent<SphereCollider>().isTrigger = false;
            carpisan.gameObject.GetComponent<SphereCollider>().isTrigger = false;
            carpisan.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(2f, 0f, 0f);
            this.GetComponent<Rigidbody>().velocity = new Vector3(2f, 0f, 0f);
            this.GetComponent<Rigidbody>().isKinematic = true;
            guc = carpisan.gameObject.GetComponent<cekimGucu>();
            guc.dusus();

            
            metin.text = "Deceased Ball:" + guc.sayac.ToString();
            StartCoroutine(eskiyeDon(carpisan));
            Debug.Log("Hilal");
            


        }
    }
    
    
    
    IEnumerator besSaniye()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(2);
        
    }
    IEnumerator eskiyeDon(Collision vuran)
    {
        yield return new WaitForSeconds(5f);
        
        vuran.gameObject.transform.Translate(new Vector3(-50f,0f,0f));
        this.transform.Translate(new Vector3(-50f,0f,0f));
        
    }
    void Update()
    {
        if (this.transform.position.x >= 490f || this.transform.position.x <= -15f || this.transform.position.z >= 490f || this.transform.position.z <= 0f)
        {
            Debug.Log("Zeynep");
            transform.Translate(Vector3.down * Time.deltaTime);
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
            
            StartCoroutine(besSaniye());

        }
        
       
        if(this.transform.position.y <=3.23f)
        {
            this.transform.position = new Vector3(this.transform.position.x, 3.23f, this.transform.position.z);
        }
    }
   
}
