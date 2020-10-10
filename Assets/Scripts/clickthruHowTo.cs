using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickthruHowTo : MonoBehaviour
{

    //Tutorial sprites
    public Sprite how_to_play;
    public Sprite how_to_play_2;
    public Sprite how_to_play_3;
    public Sprite how_to_play_4;
    private SpriteRenderer spriteRenderer;

    public GameObject button;

    public float timeOut = 0f;
    public string frameState = "1";


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = how_to_play;

        button.gameObject.SetActive(false);

    }


        void Update ()
        {
        if (Input.GetMouseButtonDown(0) && frameState == "1") // if the spriteRenderer sprite = sprite1 then change to sprite2
            {
            frameState = "2";
            timeOut = 1f;
        }
           else if (Input.GetMouseButtonDown(0) && frameState == "2")  // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            frameState = "3";
            timeOut = 1f;
        }
           else if (Input.GetMouseButtonDown(0) && frameState == "3")  // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            frameState = "4";
            timeOut = 1f;
        }
        else if (Input.GetMouseButtonDown(0) && frameState == "4")  // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            // button.gameObject.SetActive(true);
            SceneManager.LoadScene("Bearded Man Studios Inc/Scenes/MultiplayerMenu");
        }

        //framestates

        if (frameState == "1")
        {
            if (timeOut >= 0)
            {
                spriteRenderer.sprite = how_to_play;
                timeOut -= Time.deltaTime;
            }
        }
        if (frameState == "2")
        {
            if (timeOut >= 0)
            {
                spriteRenderer.sprite = how_to_play_2;
                timeOut -= Time.deltaTime;
            }
        }
        if (frameState == "3")
        {
            if (timeOut >= 0)
            {
                spriteRenderer.sprite = how_to_play_3;
                timeOut -= Time.deltaTime;
            }
        }
        if (frameState == "4")
        {
            if (timeOut >= 0)
            {
                spriteRenderer.sprite = how_to_play_4;
                timeOut -= Time.deltaTime;
            }
        }
    }
    }
    

