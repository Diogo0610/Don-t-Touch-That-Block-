using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MenuLevel : MonoBehaviour
{
    public int level;
    AudioSource Click;
    public Data dt;
    public GameObject Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10, Level11, Level12,
        Level13, Level14, Level15, Level16, LevelI, Buttons, CanvasStars, CanvasLife, CanvasLevel;
    void Start()
    {
        Click = GetComponent<AudioSource>();
        level = 0;
    }
    void Update()
    {
        levelUpdate();
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            level = 0;
        }
        if (level == 0)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Brown"))
        {
            if (GameObject.Find("Player"))
            {
                level++;
            }
        }
    }
    public void play()
    {
        Click.Play();
        level++;
    }
    public void Instructions()
    {
        Click.Play();
        level = -1;
    }
    public void Quit()
    {
        Click.Play();
        Application.Quit();
    }
    void levelUpdate()
    {
        if (level == -1)
        {
            LevelI.SetActive(true);
        }
        else
        {
            LevelI.SetActive(false);
        }

        if (level > 0)
        {
            CanvasStars.SetActive(true);
        }
        else
        {
            CanvasStars.SetActive(false);
        }

        if (level > 0)
        {
            CanvasLife.SetActive(true);
        }
        else
        {
            CanvasLife.SetActive(false);
        }

        if (level > 0)
        {
            CanvasLevel.SetActive(true);
        }
        else
        {
            CanvasLevel.SetActive(false);
        }

        if (level == 0)
        {
            Buttons.SetActive(true);
        }
        else
        {
            Buttons.SetActive(false);
        }

        if (level == 1)
        {
            Level1.SetActive(true);
        }
        else
        {
            Level1.SetActive(false);
        }

        if (level == 2)
        {
            Level2.SetActive(true);
        }
        else
        {
            Level2.SetActive(false);
        }

        if (level == 3)
        {
            Level3.SetActive(true);
        }
        else
        {
            Level3.SetActive(false);
        }

        if (level == 4)
        {
            Level4.SetActive(true);
        }
        else
        {
            Level4.SetActive(false);
        }
        if (level == 5)
        {
            Level5.SetActive(true);
        }
        else
        {
            Level5.SetActive(false);
        }
        if (level == 6)
        {
            Level6.SetActive(true);
        }
        else
        {
            Level6.SetActive(false);
        }
        if (level == 7)
        {
            Level7.SetActive(true);
        }
        else
        {
            Level7.SetActive(false);
        }
        if (level == 8)
        {
            Level8.SetActive(true);
        }
        else
        {
            Level8.SetActive(false);
        }
        if (level == 9)
        {
            Level9.SetActive(true);
        }
        else
        {
            Level9.SetActive(false);
        }
        if (level == 10)
        {
            Level10.SetActive(true);
        }
        else
        {
            Level10.SetActive(false);
        }
        if (level == 11)
        {
            Level11.SetActive(true);
        }
        else
        {
            Level11.SetActive(false);
        }
        if (level == 12)
        {
            Level12.SetActive(true);
        }
        else
        {
            Level12.SetActive(false);
        }
        if (level == 13)
        {
            Level13.SetActive(true);
        }
        else
        {
            Level13.SetActive(false);
        }
        if (level == 14)
        {
            Level14.SetActive(true);
        }
        else
        {
            Level14.SetActive(false);
        }
        if (level == 15)
        {
            Level15.SetActive(true);
        }
        else
        {
            Level15.SetActive(false);
        }
        if (level == 16)
        {
            Level16.SetActive(true);
        }
        else
        {
            Level16.SetActive(false);
        }
        if (level == 17 || dt.life == 0)
        {
            if (dt.canReturn == true)
            {
                level = 0;
            }
        }
    }
}