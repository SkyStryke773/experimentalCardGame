using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{

public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card("None", "None", 0, 0, 1));
        cardList.Add(new Card("None" , "human", 0, 0, 2));


    }

}
