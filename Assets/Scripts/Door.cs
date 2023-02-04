using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isDoorLocked;
    [SerializeField] private Animator doorAnimator;
    [SerializeField] AudioManager audioManager;
    [SerializeField] private GameObject Key2Icon;
    [SerializeField] private GameObject Win;
    private void Start()
    {
        isDoorLocked = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && !isDoorLocked)
        {
            Key2Icon.SetActive(false);
            Debug.Log("Player Won");
            doorAnimator.SetTrigger("DoorOpen");
            audioManager.PlayOneShot("Door");
            Win.SetActive(true);
        }
    }

    public void UnlockDoor()
    {
        isDoorLocked = false;
    }
}
