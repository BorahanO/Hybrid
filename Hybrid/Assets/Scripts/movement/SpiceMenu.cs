using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiceMenu : MonoBehaviour
{
    public GameObject IngredientScreen;

    public GameObject tooManyItemsScreen;

    public GameObject Ingredient;

    public string nameOfIngredient;

    public static int PickedUpSpice1;

    private void Start()
    {

        GameObject.Find("IngredientManager");

        InventoryManagement.InvManage.GetComponent<InventoryManagement>();

    }

    public void TakeSpiceWith()
    {
        if(PickedUpSpice1 <= 0)
        {
            //player picks the option yes, they take the spice with them

            IngredientScreen.SetActive(false);
            Time.timeScale = 1;

            PickedUpSpice1 = PickedUpSpice1 + 1;

            InventoryManagement.InvManage.PickedUp1 = nameOfIngredient;
            print(InventoryManagement.InvManage.PickedUp1);

            InventoryManagement.InvManage.UpdateInventory();
            InventoryManagement.InvManage.SavInvUpdate();

            Destroy(Ingredient);
        } else
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
