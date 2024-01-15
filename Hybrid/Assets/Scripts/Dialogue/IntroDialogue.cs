using TMPro;
using UnityEngine;

namespace Dialogue
{
    public class IntroDialogue : MonoBehaviour
    {
        [SerializeField] private PickRandomIngredients ingredients;
        [SerializeField] private TextMeshProUGUI listtext;

        void Update()
        {
            IngredientList();
        }

        private void IngredientList()
        {
            listtext.text = "The herbs you need to pick up are: " + ingredients.cave + ", " +ingredients.sav + ", " +ingredients.forest + ".";
        }
    }
}
