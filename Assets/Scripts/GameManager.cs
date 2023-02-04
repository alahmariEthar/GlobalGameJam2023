using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   private int collectibles;
   [SerializeField] private TextMeshProUGUI collectiblesText;
  //  [SerializeField] private TextMeshProUGUI resultText;
   // [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private GameObject storyPanel;


      // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(HideStory());
    }

     IEnumerator HideStory()
    {
        yield return new WaitForSeconds(5.0f);
        storyPanel.SetActive(false);
       // gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 public void AddCollectible()
    {
        collectibles++;
        collectiblesText.text = "" + collectibles;
    }

}
