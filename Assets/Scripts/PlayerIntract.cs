using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIntract : MonoBehaviour
{
    

 private void Update() {
    if(Input.GetKeyDown(KeyCode.E)){ 
    float intreractRange =2f;
  Collider[] colliderArray= Physics.OverlapSphere(transform.position, intreractRange);
    foreach(Collider collider in colliderArray){
   if( collider.TryGetComponent(out NPCInteractable npcInteractable)){
      npcInteractable.Interact();
   }//end if NPCInteractable
    
    }//end foreach

    }//end if (input E)
 }

}
