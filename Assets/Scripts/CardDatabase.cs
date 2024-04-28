using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{

public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new Card("enm1", "thing", 0, 0, 1));
        cardList.Add(new Card("enm2" , "human", 0, 0, 2));


    }

}
