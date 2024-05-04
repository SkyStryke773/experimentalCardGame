using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackOrginizer : MonoBehaviour
{
    public GameObject CardToHand;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartGame()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(StaticData.AttackHand[i], transform.position, transform.rotation);
        }
    }
}
