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
    public int cardHealth;
    public int id;
    public Sprite cardImage;

    public Text nameText;
    public Text descriptionText;
    public Text costText;
    public Text powerText;
    public Text healthText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject hand;
    public int numberOfCardsInDeck;



    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;

        displayCard[0] = CardDatabase.cardList[displayID];

    }

    void Update()
    {
        //displays values of cards

        cardName = displayCard[0].cardName;
        cardDescription = displayCard[0].cardDescription;
        cardCost = displayCard[0].cardCost;
        cardPower = displayCard[0].cardPower;
        cardHealth = displayCard[0]. cardHealth;
        id = displayCard[0].id;
        cardImage = displayCard[0].cardImage;



        nameText.text = "" + cardName;
        descriptionText.text = "" + cardDescription;
        costText.text = "" + cardCost;
        powerText.text = "" + cardPower;
        healthText.text = "" + cardHealth;
        artImage.sprite = cardImage;

        hand = GameObject.Find("Hand");

        if(this.transform.parent == hand.transform.parent)
        {
            cardBack = false;
        }
        staticCardBack = cardBack;
  
        if(this.tag == "Clone")
        {
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }
}
