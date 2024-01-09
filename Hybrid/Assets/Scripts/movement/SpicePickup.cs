using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpicePickup : MonoBehaviour
{
    public GameObject player;
    public string playerTag;

    public GameObject IngredientScreen;

    void Start()
    {
        IngredientScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == playerTag)
        {
            IngredientScreen.SetActive(true);

            Time.timeScale = 0;
        }

    }
}
