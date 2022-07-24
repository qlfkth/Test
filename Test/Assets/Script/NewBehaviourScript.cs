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
                Debug.Log("입력하신 점수" + namber + "은A학점입니다.");
            }
            else if (namber >= 80)
            {
                Debug.Log("입력하신 점수" + namber + "은B학점입니다.");
            }
            else if (namber >= 70)
            {
                Debug.Log("입력하신 점수" + namber + "은C학점입니다.");
            }
            if (namber < 70)
            {
                Debug.Log("입력하신 점수" + namber + "은F학점입니다.");
            }



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
