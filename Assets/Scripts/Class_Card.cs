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
    public int cardHealth;
    public int id;
    public Sprite cardImage;

    public Card()
    {



    }

    public Card(string CardName, string CardDescription, int Cost, int Power, int health, int ID, Sprite CardImage)
    {
        cardName = CardName;
        cardDescription = CardDescription;
        cardCost = Cost;
        cardPower = Power;
        cardHealth = health;
        id = ID;
        cardImage = CardImage;




    }




}
