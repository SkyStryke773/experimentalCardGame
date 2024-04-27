using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    public string cardName;
    public string cardDescription;
    public int cost;
    public int power;
    public int id;

    public Card()
    {



    }

    public Card(string CardName, string CardDescription, int Cost, int Power, int Id)
    {
        cardName = CardName;
        cardDescription = CardDescription;
        cost = Cost;
        power = Power;
        id = Id;




    }




}
