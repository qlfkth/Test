using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userlupnt = "5";

        int namber = int.Parse(userlupnt);
        if (namber % 3 == 0)
        {
            Debug.Log("3�� ����Դϴ�");
        }
        else if (namber % 3 != 0) 
        {
            Debug.Log("3�� ����� �ƴմϴ�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
