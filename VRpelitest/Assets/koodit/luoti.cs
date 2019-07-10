using UnityEngine;
using System.Collections;


public class luoti : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        HPv2 Heltti = hit.GetComponent<HPv2>();
        if (Heltti != null)
        {
            Heltti.otaDMG(100);
        }

    }

}