using UnityEngine;
using System.Collections;


public class veitsiV2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        hp Heltti = hit.GetComponent<hp>();
        if (Heltti != null)
        {
            Heltti.OtaDMG(50);
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
