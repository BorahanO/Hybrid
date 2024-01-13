using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FInalCount : MonoBehaviour
{
    public TextMeshProUGUI Score;

    public int finalscore;

    public GameObject finalScreen;

    void Start()
    {
        PickRandomIngredients.RandomIngredients.GetComponent<PickRandomIngredients>();
        InventoryManagement.InvManage.GetComponent<InventoryManagement>();

        finalScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        finalScreen.SetActive(true);
        Time.timeScale = 0;

        if (InventoryManagement.InvManage.PickedUp2 == PickRandomIngredients.RandomIngredients.cave)
        {

            finalscore = finalscore + 1;
        }

        if (InventoryManagement.InvManage.PickedUp1 == PickRandomIngredients.RandomIngredients.sav)
        {

            finalscore = finalscore + 1;
        }

        if (InventoryManagement.InvManage.PickedUp3 == PickRandomIngredients.RandomIngredients.forest)
        {
            finalscore = finalscore + 1;
        }

        Score.text = finalscore.ToString();
    }

    public void CloseScreen()
    {
        finalScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
