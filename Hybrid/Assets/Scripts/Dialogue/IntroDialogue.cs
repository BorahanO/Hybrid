using TMPro;
using UnityEngine;

namespace Dialogue
{
    public class IntroDialogue : MonoBehaviour
    {
        [SerializeField] private PickRandomIngredients ingredients;
        [SerializeField] private TextMeshProUGUI listtext;
        [SerializeField] private GameObject DialogueWindow;
        static bool DialogueViewed;
        
        private void Start()
        {
            TurnOnDialogue();
            DontDestroyOnLoad(this);
        }

        private void TurnOnDialogue()
        {
            if (!DialogueViewed)
            {
                DialogueWindow.SetActive(true);
            }
            else
            if (DialogueViewed)
            {
                DialogueWindow.SetActive(false);
            }
        }

        public void EndDialogue()
        {
            DialogueViewed = true;
        }

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
