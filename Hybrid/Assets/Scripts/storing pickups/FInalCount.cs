using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FInalCount : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public TextMeshProUGUI Score2;

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

        if (finalscore == 0)
        {
            Score.text = "Too bad we did not need any of these right now... Oh well its not like we wont use them.. but now I need to go back myself to get them... this is a predicament.";
        }
        if (finalscore == 1)
        {
            Score.text = "At least the most important one is here. I still need to go back to get more of them but you tried your best.";
        }
        if (finalscore == 2)
        {
            Score.text = "You did a good job. We are still missing one of them but I can get that myself later, at least I can finish the most important brews now.";
        }
        if (finalscore == 3)
        {
            Score.text = "Wow, amazingly done, my apprentice! Now we have all the herbs we need to finish these brews. You will make a fine pharmacist one day if you keep this up.";
        }

        Score2.text = "Final Score: " + finalscore.ToString();
    }

    public void CloseScreen()
    {
        finalScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
