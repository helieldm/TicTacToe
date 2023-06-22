using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject btnPrefab;
    public GameObject panel;
    public readonly int[] played = Enumerable.Range(0, 9).ToArray();
    List<ButtonScript> buttonScripts = new();


    public void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            GameObject b = Instantiate(btnPrefab, panel.transform);
            buttonScripts.Add(b.AddComponent<ButtonScript>());
            
        }
    }
    private void NPCTurn()
    {
        /*
        do
        {
            if (!buttons[Random.Range(0, buttons.Count)].GetComponent<ButtonScript>().clicked)
            {

            }
        }
        while (!buttons[Random.Range(0, buttons.Count)].GetComponent<ButtonScript>().clicked);
        */
    }

    private void ButtonClicked(int id)
    {

    }
}
