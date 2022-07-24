using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string uselnput = "49";

        int namber = int.Parse(uselnput);
        if (namber > 50) 
        {
            Debug.Log("50 이상의 수");
        }
        else
        {
            Debug.Log("50 미만의 수");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
