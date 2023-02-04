using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtharsCode : MonoBehaviour
{
   // [SerializeField] GameManager gameManager;
     [SerializeField] AudioManager audioManager;
     [SerializeField] private GameObject hintPanel;
     [SerializeField] private GameObject msgPanel;
      //[SerializeField] private Animator doorAnimator;
     bool _istriggered = false;

void Update() 
{
    if(Input.GetKeyDown(KeyCode.E) && _istriggered)
    {
       //  [SerializeField] private Animator doorAnimator;
        msgPanel.SetActive(true);
        Debug.Log("Second msg"); 
    }
}

 private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _istriggered = true;
         // audioManager.PlayOneShot("Collect");
            hintPanel.SetActive(true);
             Debug.Log("msg turn on");
        }

      }
 




 private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _istriggered = false;
                    msgPanel.SetActive(false);

         // audioManager.PlayOneShot("Collect");
         Debug.Log("msg turn off");
            hintPanel.SetActive(false);
            
        }
    }
  
    

  
}
