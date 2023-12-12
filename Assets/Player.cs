using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        transform.rotation = Quaternion.identity;   
        Debug.Log("진호야 미안해");
        Debug.Log("TEST");

        transform.position = Vector3.zero;
        Debug.Log("DDDD");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
