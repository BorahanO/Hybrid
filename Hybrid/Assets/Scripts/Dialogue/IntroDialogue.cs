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

        public GameObject invIngredients;
        
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
                Time.timeScale = 0;

                invIngredients.SetActive(false);
            }
            else
            if (DialogueViewed)
            {
                DialogueWindow.SetActive(false);
                Time.timeScale = 1;

                invIngredients.SetActive(true);
            }
        }

        public void EndDialogue()
        {
            DialogueViewed = true;
            Time.timeScale = 1;

            invIngredients.SetActive(true);
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
