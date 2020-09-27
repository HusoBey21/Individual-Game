using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hareket : MonoBehaviour
{
  
    

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 5f;
        float y = Input.GetAxis("Jump") * Time.deltaTime * 5f;
        transform.Translate(new Vector3(x, y, z));
        
        
            StartCoroutine(Zipzip(y));
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("AnaSayfa"); //Anasayfaya geri dönüş sağlayacak.
        }
    }
    IEnumerator Zipzip(float s)
    {
        yield return new WaitForSeconds(0.6f);

        
        transform.Translate(Vector3.down*s);
        
        
       
    }
}
