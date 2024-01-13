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

    public string PickedUp1 = "a";
    public string PickedUp2 = "b";
    public string PickedUp3 = "c";

    private void Awake()
    {
        OnlyInvManager();
        
    }

    void Start()
    {
        
        InvScreen.SetActive(false);
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
}
