using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    void OncollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
