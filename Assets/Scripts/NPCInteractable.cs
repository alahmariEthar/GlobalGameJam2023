using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    
    public void Interact(){
       // Debug.Log("Interact!");
       ChatBubble.Create(transform.transform,new Vector3(-.3f,1.7f,0f), "Hello Ethar!");
    }
}
