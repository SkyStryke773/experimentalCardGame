using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{

public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card("enm1", "thing", 1, 1, 0, Resources.Load<Sprite>("blue")));
        cardList.Add(new Card("enm2" , "human", 2, 2, 1, Resources.Load<Sprite>("dot")));
        


    }

}
