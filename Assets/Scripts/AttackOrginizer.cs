using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AttackOrginizer : MonoBehaviour
{
    public GameObject CardToHand;


    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i <= (StaticData.AttackHand.Count)-1; i++)
        {
            Debug.Log(StaticData.AttackHand[i]);
            Instantiate(StaticData.AttackHand[0], transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToCardScreen()
    {
        GameObject[] rootGameObjects = SceneManager.GetSceneByName("AttackPhase").GetRootGameObjects();
        foreach (GameObject go in rootGameObjects)
        {
            go.SetActive(false); // Toggle visibility
        }
    }
}
