using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    public int starCount;
    public int life;
    public MenuLevel ml;
    public Text Stars, Life, Level, PScore;
    public GameObject SG1, SG2,SG3, SG4, SG5, SG6, SG7, SG8, SG9, SG10, SG11, SG12, SG13, SG14, SG15, SG16;
    public bool spawn, canReturn;
    public static int score, bestScore;
    void Start()
    {
        starCount = 0;
        life = 25;
        spawn = true;
        score = 0;
        bestScore = 0;
        canReturn = false;
    }
    void Update()
    {
        Debug.Log(canReturn);
        if (life == 0 || ml.level == 0)
        {
            life = 25;
            starCount = 0;
            spawn = true;
            score = 0;
            canReturn = false;

        }
        Stars.text = "X " + starCount;
        Life.text = "X " + life;
        Level.text = "Level - " + ml.level;
        PScore.text = PlayerPrefs.GetInt("bestScore", bestScore).ToString();

        StarRespawn();
        Score();
    }
    void StarRespawn()
    {
        if (ml.level == 1)
        {
            if (ml.level == 1 && spawn == true)
            {
                Instantiate(SG1, new Vector3(-3.45f, -0.92f, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup1(Clone)"));
        }

        if (ml.level == 2)
        {
            if (ml.level == 2 && spawn == true)
            {
                Instantiate(SG2, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup2(Clone)"));
        }

        if (ml.level == 3)
        {
            if (ml.level == 3 && spawn == true)
            {
                Instantiate(SG3, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup3(Clone)"));
        }

        if (ml.level == 4)
        {
            if (ml.level == 4 && spawn == true)
            {
                Instantiate(SG4, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup4(Clone)"));
        }

        if (ml.level == 5)
        {
            if (ml.level == 5 && spawn == true)
            {
                Instantiate(SG5, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup5(Clone)"));
        }

        if (ml.level == 6)
        {
            if (ml.level == 6 && spawn == true)
            {
                Instantiate(SG6, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup6(Clone)"));
        }

        if (ml.level == 7)
        {
            if (ml.level == 7 && spawn == true)
            {
                Instantiate(SG7, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup7(Clone)"));
        }

        if (ml.level == 8)
        {
            if (ml.level == 8 && spawn == true)
            {
                Instantiate(SG8, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup8(Clone)"));
        }

        if (ml.level == 9)
        {
            if (ml.level == 9 && spawn == true)
            {
                Instantiate(SG9, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup9(Clone)"));
        }

        if (ml.level == 10)
        {
            if (ml.level == 10 && spawn == true)
            {
                Instantiate(SG10, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup10(Clone)"));
        }

        if (ml.level == 11)
        {
            if (ml.level == 11 && spawn == true)
            {
                Instantiate(SG11, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup11(Clone)"));
        }

        if (ml.level == 12)
        {
            if (ml.level == 12 && spawn == true)
            {
                Instantiate(SG12, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup12(Clone)"));
        }

        if (ml.level == 13)
        {
            if (ml.level == 13 && spawn == true)
            {
                Instantiate(SG13, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup13(Clone)"));
        }

        if (ml.level == 14)
        {
            if (ml.level == 14 && spawn == true)
            {
                Instantiate(SG14, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup14(Clone)"));
        }

        if (ml.level == 15)
        {
            if (ml.level == 15 && spawn == true)
            {
                Instantiate(SG15, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup15(Clone)"));
        }

        if (ml.level == 16)
        {
            if (ml.level == 16 && spawn == true)
            {
                Instantiate(SG16, new Vector3(0, 0, 0), Quaternion.identity);
                spawn = false;
                score = score + 100;
            }
        }
        else
        {
            Destroy(GameObject.Find("StarGroup16(Clone)"));
        }
    }
    void Score()
    {
        Debug.Log("Score: " + score);
        if (ml.level > 0)
        {
            score = ((ml.level * 50) + (life * 100) + (starCount * 50));
        }

        if (life == 0 || ml.level == 17)
        {
            PlayerPrefs.SetInt("score", score);
            canReturn = true;

            if (bestScore <= score)
            {
                bestScore = score;
                PlayerPrefs.SetInt("bestScore", bestScore);
                
            }
            
        }
    }
}
