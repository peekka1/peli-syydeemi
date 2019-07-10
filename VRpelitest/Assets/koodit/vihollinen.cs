using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class vihollinen : MonoBehaviour
{
    public Transform kohde;
    NavMeshAgent agent;

    void Start()
    {
        kohde = GameObject.Find("CameraRig").transform;
       agent = GetComponent<NavMeshAgent>();
        
    }
     void Update()
    {
        agent.SetDestination(kohde.position);
    }
}