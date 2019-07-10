using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pelaajaHP : MonoBehaviour
{
    public float heltti;
    public float maxHeltti;
    void Start()
    { 
        heltti = maxHeltti;
    }
    void Update()
    {

        if (heltti <= 0)
        {
            SceneManager.LoadScene("beninHuone");
        }
    }

    public void TapaPelaaja(float amount)
    {
        heltti -= amount;
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {
            TapaPelaaja(100);
        }
    }


}

