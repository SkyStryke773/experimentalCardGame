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
    
    
    // Start is called before the first frame update
    void Start()
    {
       
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

        GameObject card1 = AttackPos1.transform.GetChild(0).gameObject;
        GameObject card2 = AttackPos2.transform.GetChild(0).gameObject;
        GameObject card3 = AttackPos3.transform.GetChild(0).gameObject;
        GameObject card4 = AttackPos4.transform.GetChild(0).gameObject;
        GameObject card5 = AttackPos5.transform.GetChild(0).gameObject;

        StaticData.AttackHand.Add(card1);
        StaticData.AttackHand.Add(card2);   
        StaticData.AttackHand.Add(card3);
        StaticData.AttackHand.Add(card4);
        StaticData.AttackHand.Add(card5);
       


        //Debug.Log(StaticData.attackHand[0] + StaticData.attackHand[1] + StaticData.attackHand[2] + StaticData.attackHand[3] + StaticData.attackHand[4]);

        SceneManager.LoadScene("AttackPhase");
    }

}
