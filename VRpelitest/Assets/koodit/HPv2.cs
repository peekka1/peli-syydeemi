using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPv2 : MonoBehaviour
{
    public float heltti;
    public float maxHeltti;
    public Slider HpSlider;
    public GameObject HPSlider;
    public Canvas HPslideri;
    public Transform kohde;

    void Start()
    {
        kohde = GameObject.Find("CameraRig").transform;
        HPslideri = GetComponentInChildren<Canvas>();
        heltti = maxHeltti;
    }
    void Update()
    {
        HPslideri.transform.LookAt(kohde);
        if (heltti < maxHeltti)
        {
            HPSlider.SetActive(true);
        }

        HpSlider.value = heltti / maxHeltti;

        if(heltti <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void otaDMG(float amount)
    {
        heltti -= amount;
    }

  
}
