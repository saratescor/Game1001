using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int integer = 0;
        Debug.Log("Hello from varables!"); // output tex 
        Debug.Log(integer);   //Output 0 


        //int Aritmeric
        int a = 2;
        int b = 3;
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);

        //Float number (decimals)
        float c = 1f;
        float d= 3f;
        Debug.Log(c + d);
        Debug.Log(c - d);
        Debug.Log(c * d);
        Debug.Log(c / d);

       
    }

        float x = 0f;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x, 0.0f, 0.0f);
    }
}
