using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isOpponentTurn;
    public Text turnText;

    public int maxMana;
    public int currentMana;
    public Text manaText;

    public Image enviromentImage;
    public int enviromentIndex;

    public static bool startTurn;

    public GameObject AttackPos1;
    public GameObject AttackPos2;
    public GameObject AttackPos3;
    public GameObject AttackPos4;
    public GameObject AttackPos5;

    GameObject card1;
    GameObject card2;
    GameObject card3;
    GameObject card4;
    GameObject card5;

    public GameObject AttackPhasePanel;
    public GameObject AttackPhaseHand;


    int[][] cardValuess; 




    // Start is called before the first frame update
    void Start()
    {
        AttackPhasePanel.SetActive(false);

        cardValuess = new int[5][];
        cardValuess[0] = new int[2];
        cardValuess[1] = new int[2];
        cardValuess[2] = new int[2];
        cardValuess[3] = new int[2];
        cardValuess[4] = new int[2];




        /* GameObject[] rootGameObjects = SceneManager.GetSceneByName("AttackPhase").GetRootGameObjects();

         foreach (GameObject go in rootGameObjects)
         {
             go.SetActive(false); // Toggle visibility
         }
        */



        isYourTurn = true;
        yourTurn = 1;
        isOpponentTurn = 0;

        maxMana = 1;
        currentMana = 1;

        startTurn = false;

        enviromentIndex = 0;

        enviromentImage.sprite = Resources.Load<Sprite>("blue");
    }

    // Update is called once per frame
    void Update()
    {
        if (isYourTurn == true)
        {
            turnText.text = "Your Turn";
        }
        else 
        { 
            turnText.text = "Opponent Turn";
        }
        manaText.text = currentMana + "/" + maxMana;

    }
    public void endYourTurn()
    {
        isYourTurn = false;
        isOpponentTurn += 1; 
    }

    public void endOpponentTurn()
    {
        isYourTurn = true;
        yourTurn += 1;

        maxMana += 1; 
        currentMana = maxMana;

        startTurn = true;

    }

    public void switchEnviroment()
    {
        enviromentIndex++;

        switch (enviromentIndex)
        {
            case 0:
                enviromentImage.sprite = Resources.Load<Sprite>("blue");
            break;

            case 1:
            enviromentImage.sprite = Resources.Load<Sprite>("dot");
            break;

            case 2:
                enviromentImage.sprite = Resources.Load<Sprite>("cardbacktest");
            break;

            case 3:
                enviromentImage.sprite = Resources.Load<Sprite>("blue");
                enviromentIndex = 0;
            break;  

        }
    }

    public void GoToAttackScene()
    {
        AttackPhasePanel.SetActive(true);

        if (AttackPos5.transform.childCount == 1)
        {
            card5 = AttackPos5.transform.GetChild(0).gameObject;
            card5.transform.SetParent(AttackPhaseHand.transform);

            cardValuess[4][0] = card5.GetComponent<DisplayCard>().cardPower;
            cardValuess[4][1] = card5.GetComponent<DisplayCard>().cardHealth;
        }
        if (AttackPos4.transform.childCount == 1)
        {
            card4 = AttackPos4.transform.GetChild(0).gameObject;
            card4.transform.SetParent(AttackPhaseHand.transform);

            cardValuess[3][0] = card4.GetComponent<DisplayCard>().cardPower;
            cardValuess[3][1] = card4.GetComponent<DisplayCard>().cardHealth;
        }
        if (AttackPos3.transform.childCount == 1)
        {
            card3 = AttackPos3.transform.GetChild(0).gameObject;
            card3.transform.SetParent(AttackPhaseHand.transform);

            cardValuess[2][0] = card3.GetComponent<DisplayCard>().cardPower;
            cardValuess[2][1] = card3.GetComponent<DisplayCard>().cardHealth;
        }
        if (AttackPos2.transform.childCount == 1)
        {
            card2 = AttackPos2.transform.GetChild(0).gameObject;
            card2.transform.SetParent(AttackPhaseHand.transform);

            cardValuess[1][0] = card2.GetComponent<DisplayCard>().cardPower;
            cardValuess[1][1] = card2.GetComponent<DisplayCard>().cardHealth;
        }
        if (AttackPos1.transform.childCount == 1)
        {
            card1 = AttackPos1.transform.GetChild(0).gameObject;
            card1.transform.SetParent(AttackPhaseHand.transform);

            cardValuess[0][0] = card1.GetComponent<DisplayCard>().cardPower;
            cardValuess[0][1] = card1.GetComponent<DisplayCard>().cardHealth;

        }
        
       
        
       
        

        /*




        Debug.Log(StaticData.attackHand[0] + StaticData.attackHand[1] + StaticData.attackHand[2] + StaticData.attackHand[3] + StaticData.attackHand[4]);

         SceneManager.LoadScene("AttackPhase");


         Toggle the active state of each GameObject
        GameObject[] rootGameObjects = SceneManager.GetSceneByName("AttackPhase").GetRootGameObjects();

        foreach (GameObject go in rootGameObjects)
        {
            //go.SetActive(true); // Toggle visibility
       }*/
    }

}
