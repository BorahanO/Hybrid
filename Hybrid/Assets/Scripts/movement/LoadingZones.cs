using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingZones : MonoBehaviour
{
    public GameObject player;
    public string playerTag;

    public Animator transition;

    public float transitionTime = 1f;

    public string OtherArea;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag(playerTag);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == playerTag)
        {
            transition.SetTrigger("FadeOut");
            LoadNextLevel();
        }

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(OtherArea));
    }

    IEnumerator LoadLevel(string LevelName)
    {
        
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(OtherArea);
    }
}
