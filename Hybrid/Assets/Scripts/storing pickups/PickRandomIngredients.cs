using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomIngredients : MonoBehaviour
{
    public static PickRandomIngredients RandomIngredients;

    public List<string> IngredientsCave = new List<string>();
    public List<string> IngredientsSav = new List<string>();
    public List<string> IngredientsForest = new List<string>();
    
    public string cave;
    public string sav;
    public string forest;
    
    private void Awake()
    {
        OnlyIngredientManager();
    }

    void Start()
    {
        DontDestroyOnLoad(this);
        IngredientsCave.Add("Gnomears");
        IngredientsCave.Add("Spider Claws");
        IngredientsCave.Add("Fairy Greaves");
        IngredientsCave.Add("Dragonscales");

        IngredientsSav.Add("Baldorus");
        IngredientsSav.Add("Fairy Wings");
        IngredientsSav.Add("Ruthlees");
        IngredientsSav.Add("Demphuree");

        IngredientsForest.Add("Snees Grass");
        IngredientsForest.Add("Tong melt");
        IngredientsForest.Add("Deathkiss");

        RandomizeCave();
        RandomizeSav();
        RandomizeForest();
    }

    
    public void RandomizeCave()
    {
        GetRandomItem(IngredientsCave);

        string GetRandomItem(List<string> listToRandomize)
        {
            int randomNum = Random.Range(0, listToRandomize.Count);
            string printRandom = listToRandomize[randomNum]; 
            print(printRandom);

            cave = printRandom;
            return printRandom;
        }
    }

    public void RandomizeSav()
    {
        GetRandomItem(IngredientsSav);

        string GetRandomItem(List<string> listToRandomize)
        {
            int randomNum = Random.Range(0, listToRandomize.Count);
            string printRandom = listToRandomize[randomNum];
            print(printRandom);

            sav = printRandom;
            return printRandom;
        }
    }

    public void RandomizeForest()
    {
        GetRandomItem(IngredientsForest);

        string GetRandomItem(List<string> listToRandomize)
        {
            int randomNum = Random.Range(0, listToRandomize.Count);
            string printRandom = listToRandomize[randomNum];
            print(printRandom);

            forest = printRandom;
            return printRandom;
        }
    }

    void OnlyIngredientManager()
    {
        if (RandomIngredients == null)
        {
            DontDestroyOnLoad(this);
            RandomIngredients = this;
        }
        else
        {
            if (RandomIngredients != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
