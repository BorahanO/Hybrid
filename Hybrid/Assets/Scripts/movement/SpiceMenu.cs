using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiceMenu : MonoBehaviour
{
    public GameObject IngredientScreen;

    public GameObject Ingredient;

    public void TakeSpiceWith()
    {
        //player picks the option yes, they take the spice with them

        IngredientScreen.SetActive(false);
        Time.timeScale = 1;


        //code part where it gets stored when the played picks up the spice, (also part where they have limited space? would be different script)

        Destroy(Ingredient);
    }

    public void DoNotTakeSpiceWith()
    {
        //player picks option no, they do not take the spice with them

        IngredientScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
