using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public Slider slider;
    public float alotusHp = 100f;
    public Color taysHpVari = Color.green;
    public Color nollaHpVari = Color.red;
    public Image taytaKuva;
    public float nykyinenHp;
    private bool Kuollut;
    public GameObject HPSlider;


    private void OnEnable()
    {
        nykyinenHp = alotusHp;
        Kuollut = false;

        SetHealthUI();
    }

    private void SetHealthUI()
    {
        slider.value = nykyinenHp;
        taytaKuva.color = Color.Lerp(nollaHpVari, taysHpVari, nykyinenHp / alotusHp);

        if (nykyinenHp < alotusHp)
        {
            HPSlider.SetActive(true);
        }
    }
public void OtaDMG(float amount)
    {
        nykyinenHp -= amount;
        SetHealthUI();
        if (nykyinenHp <= 0f && !Kuollut)
        {
            Kuollessa();
        }
    }
    private void Kuollessa()
    {
        Kuollut = true;
        if(Kuollut==true)
        {
            Destroy(gameObject);
        }
       
    }
}
