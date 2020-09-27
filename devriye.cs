using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class devriye : MonoBehaviour
{
    public float surat = 5f;//Sürat belirlendi
    public float yonDegistirmeAraligi = 1f; //Aralık belirlendi
    public float enBuyukDegisim = 30f; //En büyük değişim belirlendi.
    CharacterController denetleyici; //Denetleyici belirlendi.
    float onculuk;
    Vector3 hedefDonusu; //Bu dönüşü belirleyecek.
    public Transform boyut;
    [SerializeField]
    Terrain arazi;
    bool zemin=true;
    void Awake()
    {
        boyut = GameObject.Find("Arazi").transform;
        arazi = boyut.GetComponent<Terrain>();
        denetleyici = GetComponent<CharacterController>();
        onculuk = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0f, onculuk, 0f);
        StartCoroutine(yeniOncu()); //Yeni öncü olacak.
        zemin = denetleyici.isGrounded;
        
    }
    void Update()
    {

       


            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, hedefDonusu, Time.deltaTime * yonDegistirmeAraligi);
            Vector3 ileri = transform.TransformDirection(Vector3.forward); //Yön belirler.
            denetleyici.SimpleMove(ileri * surat); //Basit hareket demek.
                                             // Debug.Log((arazi.terrainData.alphamapHeight - transform.position.z));
            


           

                StartCoroutine(geri(ileri));

            
        
        

        
        
    }
    IEnumerator geri(Vector3 x)
    {
        yield return new WaitForSeconds(.2f);
        
              
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, hedefDonusu, Time.deltaTime * yonDegistirmeAraligi);
        Vector3 tersİleri = transform.TransformDirection(-1 * x);
            denetleyici.SimpleMove(tersİleri * surat);
        
    }
    IEnumerator yeniOncu()
    {
        while(true)
        {
            onYeni();
            yield return new WaitForSeconds(yonDegistirmeAraligi);

        }
    }
    void onYeni()
    {
        var zemin = Mathf.Clamp((onculuk - enBuyukDegisim), 0, 30);
        var tavan = Mathf.Clamp((onculuk + enBuyukDegisim), 0, 30);
        onculuk = Random.Range(zemin, tavan);
        hedefDonusu = new Vector3(0f, onculuk, 0f);
    }
    
}
