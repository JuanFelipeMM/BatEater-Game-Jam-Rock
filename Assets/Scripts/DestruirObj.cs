using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObj : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 2f);
    }
   
}
