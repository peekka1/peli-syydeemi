using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class pistooli : MonoBehaviour
{
    private float ajastin;
    public GameObject oikeaOhjain;
    private SteamVR_TrackedObject ase;
    private SteamVR_Controller.Device laite;
    public GameObject luodinReika;
    private SteamVR_TrackedController ohjain;
    public Transform piippu;
    // Start is called before the first frame update
    void Start()
    {
        ohjain = oikeaOhjain.GetComponent<SteamVR_TrackedController>();
        ase = oikeaOhjain.GetComponent<SteamVR_TrackedObject>();
    }

    
    private void Update()
    {
        ajastin -= Time.deltaTime;
        if (ohjain.triggerPressed)
        {
            if (ajastin < 0)
            {
                ShootWeapon();
            }
            
        }
    }
    
   

    public void ShootWeapon()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = new Ray(piippu.position, piippu.forward);
        laite = SteamVR_Controller.Input((int)ase.index);
        laite.TriggerHapticPulse(750);
        ajastin = 2f;
        
        Debug.Log("pam");


        if(Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(piippu.position, hit.point, Color.red, 2.5f);
            Instantiate(luodinReika, hit.point, Quaternion.identity);  
            if (hit.collider.gameObject.tag == "enemy")
            {
                HPv2 Heltti = hit.collider.gameObject.GetComponent<HPv2>();
                if (Heltti != null)
                {
                    Heltti.otaDMG(100);
                }
            }
                
                
        }
        
    }

    
}
