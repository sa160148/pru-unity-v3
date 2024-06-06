using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    private TextAsset inkJSON;
    private bool playerInrange;

    private void Awake()
    {
        playerInrange = false;
        visualCue.SetActive(false);
    }
    private void Update()
    {
        if (playerInrange){
            if(InputManager.GetInstance().GetInteractPressed()){
                // DialogueManager.GetInstance().StartDialogue(inkJSON);
                Debug.Log(inkJSON.text);
            }
        } 
        else{
            visualCue.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInrange = true;
            // visualCue.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInrange = false;
            // visualCue.SetActive(false);
        }
    }
}
