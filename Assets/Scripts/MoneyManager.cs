using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //impedir la compra
            Debug.Log("dinero insuficiente");
        }
        else
        {
            money += amount;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
