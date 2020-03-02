using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Balans balans;

    float current;

    public float Current
    {
        get
        {
            return current;
        }
    }


    private void Awake()
    {
        current = balans.Health;
    }



    public void ApplyDamage(float damage)
    {
        current -= damage;
    }
}
