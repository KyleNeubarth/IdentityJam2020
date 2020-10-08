using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchBrowser : MonoBehaviour
{
    public Sprite browser; // Drag your first sprite here
    public Sprite history; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = browser; // set the sprite to sprite1
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If the space bar is pushed down
     {
         ChangeSprite (); // call method to change sprite
     }
 }
 
 void ChangeSprite ()
 {
     if (spriteRenderer.sprite == browser) // if the spriteRenderer sprite = sprite1 then change to sprite2
     {
         spriteRenderer.sprite = history;
     }
     else
     {
         spriteRenderer.sprite = browser; // otherwise change it back to sprite1
     }
    }
}
