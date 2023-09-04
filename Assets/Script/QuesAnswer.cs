using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuesAnswer : MonoBehaviour
{
    int range;
    int[] oldRange = { -1, -1, -1 };
    int counter = 1;
    public static int score = 0;

    public Canvas GameCan;
    public Canvas WinCan;

    public Text questions;
    public Text answerA;
    public Text answerB;
    public Text answerC;
    public Text answerD;

    public Text ScoreText;
    public Text FinalScore;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource audio;

    bool Answ1;
    bool Answ2;
    bool Answ3;
    bool Answ4;

    public Button Button_1;
    public Button Button_2;
    public Button Button_3;
    public Button Button_4;


    // Use this for initialization
    void Start()
    {

        counter = 0;
        SelectingRange();
        audio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SelectingRange()
    {
        //Button_1.interactable = true;
      //  Button_2.interactable = true;
      //  Button_3.interactable = true;
        //Button_4.interactable = true;

        Button_1.GetComponent<Image>().color = Color.white;
        Button_2.GetComponent<Image>().color = Color.white;
        Button_3.GetComponent<Image>().color = Color.white;
        Button_4.GetComponent<Image>().color = Color.white;

       // range = Random.Range(0, 3);
       range = Random.Range (1,4);
        for (int i = 0; i < oldRange.Length; i++)
        {
            if (range == oldRange[i])
            {
                range = Random.Range(1, 4);
                i = 0;
                
            }
            if (counter == oldRange.Length)
            {
                YouWon();
                break;

            }
        }
        

        oldRange[counter] = range;
        for (int i = 1; i < oldRange.Length; i++)
        {
            Debug.Log("Testing" + oldRange[i]);
        }
        SpawnQuestion();
        counter++;


    }

    void SpawnQuestion()
    {
        if (range == 1)
        {
            questions.text = "Where is UPM located?";
            answerA.text = "Serdang";
            answerB.text = "Gombak";
            answerC.text = "Bangi";
            answerD.text = "Kuala Lumpur";
            Answ1 = true;

        }

        if (range == 2)
        {
            questions.text = "What you should do if you are in trouble at college?";
            answerA.text = "Stay calm";
            answerB.text = "Contact felo";
            answerC.text = "Call police";
            answerD.text = "Just go";
            Answ2 = true;

        }

        if (range == 3)
        {
            questions.text = "If co-supervisor asked you to do something that out from your field, what you should do?";
            answerA.text = "Do nothing";
            answerB.text = "Tolerate with them";
            answerC.text = "Cancel the project";
            answerD.text = "Asked for help";
            Answ2 = true;

        }

    }

    public void Button1()
    {
        DissableButton();

        if (Answ1 == true)
        {
            Button_1.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ1 = false;
            AddScore();
            audio.PlayOneShot(correctSound);

        }

        else
        {
            Button_1.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            audio.PlayOneShot(wrongSound);
        }
    }

    public void Button2()
    {
        DissableButton();

        if (Answ2 == true)
        {
            Button_2.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ2 = false;
            AddScore();
            audio.PlayOneShot(correctSound);

        }

        else
        {
            Button_2.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            //MinusScore();
            audio.PlayOneShot(wrongSound);
        }
    }

    public void Button3()
    {
        DissableButton();

        if (Answ3 == true)
        {
            Button_3.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ3 = false;
            AddScore();
            audio.PlayOneShot(correctSound);

        }

        else
        {
            Button_3.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            audio.PlayOneShot(wrongSound);
        }
    }

    public void Button4()
    {
        DissableButton();

        if (Answ4 == true)
        {
            Button_4.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ4 = false;
            AddScore();
            audio.PlayOneShot(correctSound);

        }

        else
        {
            Button_4.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            audio.PlayOneShot(wrongSound);
        }
    }

    void AddScore()
    {
        score = score + 2;
        ScoreText.text = "SCORE : " + score;

    }


    /*void MinusScore (){

        score = score - 1;
        ScoreText.text = "SCORE: " + score;

        if (score < 0)
        {
            score = 0;
            ScoreText.text = "SCORE: " + score;

        }

    }
    */

    void YouWon()
    {
        GameCan.gameObject.SetActive(false);
        WinCan.gameObject.SetActive(true);
        FinalScore.text = "Your score is " + score;
    }


    public void ButtonMenu()
    {
        SceneManager.LoadScene("");
    }


    void DissableButton()
    {
      //  Button_1.interactable = false;
       // Button_2.interactable = false;
       // Button_3.interactable = false;
       // Button_4.interactable = false;

    }


}
