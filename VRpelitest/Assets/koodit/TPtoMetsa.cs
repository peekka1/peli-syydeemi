using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPtoMetsa : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (tag == "Player")
        {
            SceneManager.LoadScene("mappiUus");
        }
    }
}
