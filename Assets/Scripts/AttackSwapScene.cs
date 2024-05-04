using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackSwapScene : MonoBehaviour
{
    public GameObject AttackPos1;  
    public GameObject AttackPos2;   
    public GameObject AttackPos3;
    public GameObject AttackPos4;
    public GameObject AttackPos5;
    public void GoToAttackScene()
    {
        //StaticData.attackHand[0] = AttackPos1;






        SceneManager.LoadScene("AttackPhase");
    }
}
