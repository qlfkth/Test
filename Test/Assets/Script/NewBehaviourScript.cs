using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userlnput = "69";

        int namber = int.Parse(userlnput);
        if (namber > 0) 
        {
            if (namber >= 90)
            {
                Debug.Log("�Է��Ͻ� ����" + namber + "��A�����Դϴ�.");
            }
            else if (namber >= 80)
            {
                Debug.Log("�Է��Ͻ� ����" + namber + "��B�����Դϴ�.");
            }
            else if (namber >= 70)
            {
                Debug.Log("�Է��Ͻ� ����" + namber + "��C�����Դϴ�.");
            }
            if (namber < 70)
            {
                Debug.Log("�Է��Ͻ� ����" + namber + "��F�����Դϴ�.");
            }



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
