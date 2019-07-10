using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class tpwand : MonoBehaviour
{
    private float ajastin;
    public GameObject vasenOhjain;
    private SteamVR_TrackedObject wand;
    private SteamVR_Controller.Device laite;
    private SteamVR_TrackedController ohjain;
    public Transform piippu;
    public Transform pelaaja;
    // Start is called before the first frame update
    void Start()
    {
        ohjain = vasenOhjain.GetComponent<SteamVR_TrackedController>();
        wand = vasenOhjain.GetComponent<SteamVR_TrackedObject>();
    }


    private void Update()
    {
        ajastin -= Time.deltaTime;
        if (ohjain.triggerPressed)
        {
            if (ajastin < 0)
            {
                TelePort();
            }

        }
    }



    public void TelePort()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(piippu.position, piippu.forward);
        laite = SteamVR_Controller.Input((int)wand.index);
        laite.TriggerHapticPulse(750);
        ajastin = 3f;

        Debug.Log("woosh");


        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(piippu.position, hit.point, Color.green, 2.5f);
            pelaaja.transform.position = hit.point;

        }
    }
}
    
