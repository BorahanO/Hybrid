using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiceMenuCave : MonoBehaviour
{
    public GameObject IngredientScreen;

    public GameObject tooManyItemsScreen;

    public GameObject Ingredient;

    public string nameOfIngredient;


    public static int PickedUpSpice2;

    private void Start()
    {

        GameObject.Find("IngredientManager");

        InventoryManagement.InvManage.GetComponent<InventoryManagement>();
    }

    public void TakeSpiceWith()
    {
        if (PickedUpSpice2 <= 0)
        {
            //player picks the option yes, they take the spice with them

            IngredientScreen.SetActive(false);
            Time.timeScale = 1;

            PickedUpSpice2 = PickedUpSpice2 + 1;

            InventoryManagement.InvManage.PickedUp2 = nameOfIngredient;
            print(InventoryManagement.InvManage.PickedUp2);
            
            InventoryManagement.InvManage.UpdateInventory();

            Destroy(Ingredient);
        }
        else
        {
            tooManyItemsScreen.SetActive(true);
            IngredientScreen.SetActive(false);
        }
    }

    public void DoNotTakeSpiceWith()
    {
        //player picks option no, they do not take the spice with them

        IngredientScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void TooManyItems()
    {
        //when player has too many items this screen comes up and they only have an "ok" option to continue
        tooManyItemsScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
