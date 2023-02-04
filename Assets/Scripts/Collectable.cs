using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
     [SerializeField] AudioManager audioManager;
     public GameObject theGhost;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player collected a candle!!");
          audioManager.PlayOneShot("Collect");
            Destroy(gameObject);
            gameManager.AddCollectible();
        }
    }
    //theGhost.SetActive(true);




}
