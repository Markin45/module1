using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BalansGame", menuName = "BalansGame", order = 51)]
public class Balans : ScriptableObject
{
    [SerializeField] private int health = 3;
    [SerializeField] private int power = 1;

    public int Health
    {
        get
        {
            return health;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }
    }

}
