using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : MonoBehaviour
{
    public int playerHealthData;
    
    

    public static List<GameObject> AttackHand = new List<GameObject>();

    void Start()
    {
        Debug.Log(AttackHand);

    }

    
    void Update()
    {
        
    }
}
