using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    
      public static void Create(Transform parent, Vector3 localPosition, string text){
          Transform ChatBubbleTransform = Instantiate(GameAssets.i.pfCahtBubble, parent);
          ChatBubbleTransform.localPosition =localPosition;

          ChatBubbleTransform.GetComponent<ChatBubble>().Setup(text);

          Destroy(ChatBubbleTransform.gameObject, 4f);
      }

    private SpriteRenderer backgroundsprintRender;
    private SpriteRenderer iconSpriteRenderer;
    private TextMeshPro textMeshPro;
   private void Awake() {
        backgroundsprintRender =transform.Find("BackGround").GetComponent<SpriteRenderer>();
            iconSpriteRenderer =transform.Find("Icon").GetComponent<SpriteRenderer>();
                textMeshPro =transform.Find("Text").GetComponent<TextMeshPro>();
    }

private void Start() {
    Setup("Hello World! Say Hi to my frind");
}
    private void Setup(string text){
       textMeshPro.SetText(text);
       textMeshPro.ForceMeshUpdate();
      Vector2 textSize= textMeshPro.GetRenderedValues(false);

      Vector2 padding =new Vector2(1f,1f);
      backgroundsprintRender.size =textSize +padding;
    }

}
