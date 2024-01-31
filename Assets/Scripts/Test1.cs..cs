using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test1.cs. : MonoBehaviour
{
    // Start is called before the first frame update

//Name: Sara Cortes
//Student ID: 101498340

 [SerializeField]
float SalesValue;

void Start()
{
    if (SalesValue >= 0)
    {
        float BaseSalary = 200f;
        float CommissionBelow2000 = 0.9f;
        float CommissionAbove2000 = 0.15f;

        float earning;

        if (SalesValue >= 2000)
        {
            earning = BaseSalary + (SalesValue * CommissionAbove2000);
        }
        else
        {
            float salesBelow2000 = 2000f;
            float salesAbove2000 = SalesValue - salesBelow2000;

            earning = BaseSalary + (salesBelow2000 * CommissionBelow2000) + (salesAbove2000 * CommissionAbove2000);
        }

        Debug.Log("SalesPerson Earning: $" + earning);
    }
    else
    {
        Debug.Log("Error");
    }
}




// Update is called once per frame
void Update()
    {
        
    }
}
