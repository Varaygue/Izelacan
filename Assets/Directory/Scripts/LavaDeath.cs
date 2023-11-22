using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeath : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider lavaBlock)
    {
        Debug.Log("Burned !");
    }
}
