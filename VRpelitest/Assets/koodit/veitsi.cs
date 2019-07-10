using UnityEngine;
using System.Collections;


public class veitsi : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        HPv2 Heltti = hit.GetComponent<HPv2>();
        if (Heltti != null)
        {
            Heltti.otaDMG(50);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Invoke("tuhoa", 10);

    }

    void tuhoa()
    {
        Destroy(gameObject);
    }
}
