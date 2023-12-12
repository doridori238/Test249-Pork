using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        transform.rotation = Quaternion.identity;
        Debug.Log("asdfasdf");
        Debug.Log("qwer");
        Debug.Log("ÁøÈ£¾ß ¹Ì¾ÈÇØ");
        Debug.Log("TEST");
        Debug.Log("ê´œì°®ì•„ ì•„ë§ˆë„?");
        transform.position = Vector3.zero;
        Debug.Log("DDDD");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("ATTack");
        else
            Debug.Log("ddd");
    }
}
