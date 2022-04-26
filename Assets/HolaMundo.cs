using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HolaMundo : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void holaWorld()
    {
        if (num1 == num2 || num1 < num2)
        {
            Debug.Log("Error, Asegúrese que el Primer Número sea Mayor que el Segundo");
        }

        else
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }

        /*int i = 1;
        while (i < 100)
        {
            Debug.Log(i);
            i++;
        }*/
       

    }
}
