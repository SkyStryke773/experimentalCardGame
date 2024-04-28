using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public string cardName;
    public string cardDescription;
    public int cardCost;
    public int cardPower;
    public int id;
    public Sprite cardImage;

    public Card()
    {



    }

    public Card(string CardName, string CardDescription, int Cost, int Power, int ID, Sprite CardImage)
    {
        cardName = CardName;
        cardDescription = CardDescription;
        cardCost = Cost;
        cardPower = Power;
        id = ID;
        cardImage = CardImage;




    }




}
