using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManagement : MonoBehaviour
{
    public static InventoryManagement InvManage;

    public GameObject InvScreen;

    public TextMeshProUGUI Ingredient1;
    public TextMeshProUGUI Ingredient2;
    public TextMeshProUGUI Ingredient3;

    public TextMeshProUGUI IngredientNeed1;
    public TextMeshProUGUI IngredientNeed2;
    public TextMeshProUGUI IngredientNeed3;

    public string PickedUp1 = "a";
    public string PickedUp2 = "b";
    public string PickedUp3 = "c";

    public GameObject gnomears;
    public GameObject spiderClaws;
    public GameObject fairyGraves;
    public GameObject dragonScales;

    public GameObject sneesGrass;
    public GameObject tongMelt;
    public GameObject deathKiss;

    public GameObject baldorus;
    public GameObject fairyWings;
    public GameObject ruthlees;
    public GameObject demphuree;

    private void Awake()
    {
        OnlyInvManager();
        
    }

    void Start()
    {
        PickRandomIngredients.RandomIngredients.GetComponent<PickRandomIngredients>();

        InvScreen.SetActive(false);

        gnomears.SetActive(false);
        spiderClaws.SetActive(false);
        fairyGraves.SetActive(false);
        dragonScales.SetActive(false);

        sneesGrass.SetActive(false);
        tongMelt.SetActive(false);
        deathKiss.SetActive(false);

        baldorus.SetActive(false);
        fairyWings.SetActive(false);
        ruthlees.SetActive(false);
        demphuree.SetActive(false);
    }

    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(InvScreen.activeSelf != true)
            {
                InvScreen.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                InvScreen.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void UpdateList()
    {
        IngredientNeed1.text = PickRandomIngredients.RandomIngredients.sav.ToString();
        IngredientNeed2.text = PickRandomIngredients.RandomIngredients.cave.ToString();
        IngredientNeed3.text = PickRandomIngredients.RandomIngredients.forest.ToString();
    }

    public void UpdateInventory()
    {
        Ingredient1.text = PickedUp1.ToString();
        Ingredient2.text = PickedUp2.ToString();
        Ingredient3.text = PickedUp3.ToString();
    }

    void OnlyInvManager()
    {
        if (InvManage == null)
        {
            DontDestroyOnLoad(this);
            InvManage = this;
        }
        else
        {
            if(InvManage != this)
            {
                Destroy(gameObject);
            }
        }
    }

    public void SavInvUpdate()
    {
        if (InventoryManagement.InvManage.PickedUp1 == "Baldorus")
        {
            baldorus.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp1 == "Fairy Wings")
        {
            fairyWings.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp1 == "Ruthlees")
        {
            ruthlees.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp1 == "Demphuree")
        {
            demphuree.SetActive(true);
        }
    }

    public void CaveInvUpdate()
    {
        if (InventoryManagement.InvManage.PickedUp2 == "Gnomears")
        {
            gnomears.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp2 == "Spider Claws")
        {
            spiderClaws.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp2 == "Fairy Greaves")
        {
            fairyGraves.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp2 == "Dragonscales")
        {
            dragonScales.SetActive(true);
        }
    }

    public void ForestInvUpdate()
    {
        if (InventoryManagement.InvManage.PickedUp3 == "Snees Grass")
        {
            sneesGrass.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp3 == "Tong Melt")
        {
            tongMelt.SetActive(true);
        }

        if (InventoryManagement.InvManage.PickedUp3 == "Deathkiss")
        {
            deathKiss.SetActive(true);
        }

    }
}
