using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AxeBehavior : MonoBehaviour
{

    private void OnTriggerEnter(Collider Player)
    {
        SceneManager.LoadScene("Test_Blockout");
    }
}
