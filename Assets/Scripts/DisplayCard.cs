using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayID;

    public string cardName;
    public string cardDescription;
    public int cardCost;
    public int cardPower;
    public int id;

    public Text nameText;
    public Text descriptionText;
    public Text costText;
    public Text powerText;


    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayID];
    }

    void Update()
    {
        
        cardName = displayCard[0].name;
        cardDescription = displayCard[0].cardDescription;
        cardCost = displayCard[0].cost;
        cardPower = displayCard[0].power;
        id = displayCard[0].id;




    }
}
