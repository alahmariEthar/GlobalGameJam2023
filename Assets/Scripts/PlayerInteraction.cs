using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    // [SerializeField] GameManager gameManager;
    [SerializeField] private Door door;
     [SerializeField] AudioManager audioManager;
     [SerializeField] private GameObject hintPanel;
     [SerializeField] private GameObject msgPanel;
     [SerializeField] private GameObject ShovelIcon;
     [SerializeField] private GameObject CandleIcon;
     [SerializeField] private GameObject FlowerHolder;
     [SerializeField] private GameObject PutTheFlower;
     [SerializeField] private GameObject hintGrave;
     [SerializeField] private GameObject MikeMsg;
     [SerializeField] private GameObject KeyHiden;
     [SerializeField] private GameObject ChestClose;
     [SerializeField] private GameObject ChestOpen;
     [SerializeField] private GameObject PressEforChest;
     [SerializeField] private GameObject map;
     [SerializeField] private GameObject mapIcon;
     [SerializeField] private GameObject KeyIcon;
     [SerializeField] private GameObject Key2Icon;
    [SerializeField] private GameObject ShowKeyTree;
    [SerializeField] private GameObject PressETree;
    [SerializeField] private GameObject PressEDoor;



      public GameObject ghost;
     bool _istriggered = false;
  bool TriggerGrave = false;
 bool GotKeyChest=false;
bool openChest=false;
bool GotMap=false;
bool GotShovel=false;
bool digISTrue=false;
bool FinalKeyHere=false;
     //Candle
      private int candle=0;
       private int flower=0;
   [SerializeField] private TextMeshProUGUI displaytheCandle;
    [SerializeField] private TextMeshProUGUI displaytheFlower;

void Update() 
{
     displaytheCandle.text =(""+candle); 
       displaytheFlower.text =(""+flower); 
    if(Input.GetKeyDown(KeyCode.E) && _istriggered)
    {
        msgPanel.SetActive(true);
        Debug.Log("Second msg"); 
          hintPanel.SetActive(false);
    }

     if(Input.GetKeyDown(KeyCode.E) && TriggerGrave){
        ghost.SetActive(true);
        MikeMsg.SetActive(true);
        PutTheFlower.SetActive(true);
        hintGrave.SetActive(false);
        KeyHiden.SetActive(true);
        FlowerHolder.SetActive(false);
        CandleIcon.SetActive(false);
        audioManager.PlayOneShot("magic");
       //   ghost.GetComponent<Animator>().SetTrigger("ScrollUP");
       // audioManager.Play("Dooropening");
      }

 if(Input.GetKeyDown(KeyCode.E)&&openChest){
      PressEforChest.SetActive(false);
      ChestClose.SetActive(false); 
      ChestOpen.SetActive(true);
    map.SetActive(true);
    mapIcon.SetActive(true);
    KeyIcon.SetActive(false);
    GotMap=true;
  //  sm.PlayCoinCollect();
      }

       if(Input.GetKeyDown(KeyCode.E)&&digISTrue){
        ShowKeyTree.SetActive(true);
      mapIcon.SetActive(false);
      ShovelIcon.SetActive(false);
      PressETree.SetActive(false);
      audioManager.PlayOneShot("dig");
  //  sm.PlayCoinCollect();
      }
       if(FinalKeyHere){
      PressEDoor.SetActive(true);
   //  sm.PlayCoinCollect();
    }



}

 private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Book"))
        {
            _istriggered = true;
         // audioManager.PlayOneShot("Collect");
            hintPanel.SetActive(true);
             Debug.Log("msg turn on");
        }
       // if (other.gameObject.CompareTag("grave")){
                // TriggerGrave = true;
         // audioManager.PlayOneShot("Collect");
          //  hintGrave.SetActive(true);     Debug.Log("msg turn on"); }

         if (other.gameObject.CompareTag("Shovel")) {
          //  _istriggered = true;
         Destroy(other.gameObject);
            ShovelIcon.SetActive(true);
             Debug.Log("msg turn on");
             GotShovel = true;
             audioManager.PlayOneShot("Collect");

        }
          if (other.gameObject.CompareTag("Key")) {
          //  _istriggered = true;
         Destroy(other.gameObject);
          audioManager.PlayOneShot("Collect");
             Debug.Log("msg turn on");
             GotKeyChest=true;
             KeyIcon.SetActive(true);
        }
         if(other.gameObject.CompareTag("Candle")){
      candle+=1;
      Debug.Log("I collect this much of Candle!!"+candle);
      CandleIcon.SetActive(true);
     audioManager.PlayOneShot("Collect");
     Destroy(other.gameObject);
    }

     if(other.gameObject.CompareTag("grave")&&candle>=3&&flower>=5){
   // ghost.SetActive(true);
     hintGrave.SetActive(true);
     Debug.Log("press E");
     TriggerGrave = true;
      //sm.PlayWinSound();
       //win.SetActive(true);  
       }

    if(other.gameObject.CompareTag("Flower")){
      flower+=1;
      Debug.Log("I collect this much of Candle!!"+flower);
      FlowerHolder.SetActive(true);
       Destroy(other.gameObject);
  audioManager.PlayOneShot("Collect");
    }

if(other.gameObject.CompareTag("Chest")&&GotKeyChest){
      PressEforChest.SetActive(true);
      openChest=true;
      //if(Input.GetKeyDown(KeyCode.E)){
       // Destroy(other.gameObject);
       //ChestClose.SetActive(false); }
   //  sm.PlayCoinCollect();
    }

    if(other.gameObject.CompareTag("Tree")&&GotShovel&&GotMap){
      PressETree.SetActive(true);
      digISTrue=true;
    //  ShowKeyTree.SetActive(true);
      // mapIcon.SetActive(false);
      // ShovelIcon.SetActive(false);
   //  sm.PlayCoinCollect();
    }
    if(other.gameObject.CompareTag("Key2")){
        Destroy(other.gameObject);
        Key2Icon.SetActive(true);
       FinalKeyHere=true;
        door.UnlockDoor();
   //  sm.PlayCoinCollect();
    }

    


//if(other.gameObject.CompareTag("Door")&&FinalKeyHere){
  //  Destroy(other.gameObject);
   //  sm.PlayCoinCollect();  }

      }

     private void OnTriggerExit(Collider other)
      {
        if (other.gameObject.CompareTag("Book"))
        {
           _istriggered = false;
                    msgPanel.SetActive(false);
         // audioManager.PlayOneShot("Collect");
         Debug.Log("msg turn off");
            hintPanel.SetActive(false); 
        }

          if (other.gameObject.CompareTag("grave"))
        {
            TriggerGrave = false;
         // audioManager.PlayOneShot("Collect");
         Debug.Log("msg turn off");
            hintGrave.SetActive(false);
            ghost.SetActive(false);
          MikeMsg.SetActive(false);
         //   FlowerHolder.SetActive(false);
        //CandleIcon.SetActive(false); 
        }

          if (other.gameObject.CompareTag("Tree"))
        {
         PressETree.SetActive(false);
            
        }



    }
}
