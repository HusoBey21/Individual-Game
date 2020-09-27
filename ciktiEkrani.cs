using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ciktiEkrani : MonoBehaviour
{
    public Text metin;

    // Update is called once per frame
    void Update()
    {
        metin.text = "FAILED";
        StartCoroutine(yukle());
    }
    IEnumerator yukle()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(1);
    }
}
