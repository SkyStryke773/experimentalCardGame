using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpponentHealth : MonoBehaviour
{

    public static float maxHp;
    public static float staticHp;
    public float hp;
    public Image health;
    public Text hpText;

    void Start()
    {
        maxHp = 50;
        staticHp = 50;
    }

    void Update()
    {
        hp = staticHp;
        health.fillAmount = hp / maxHp;
        if (hp >= maxHp)
        {
            hp = maxHp;
        }
        hpText.text = hp + "HP";
    }
}
