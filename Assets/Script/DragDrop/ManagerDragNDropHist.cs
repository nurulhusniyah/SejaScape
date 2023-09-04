using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerDragNDropHist : MonoBehaviour
{

    public bool Checked1 = false;
    public bool Checked2 = false;
    public bool Checked3 = false;
    public bool Checked4 = false;

    public GameObject wrong1;
    public GameObject right1;
    public GameObject wrong2;
    public GameObject right2;
    public GameObject wrong3;
    public GameObject right3;
    public GameObject wrong4;
    public GameObject right4;

    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;


    public int Score1, Score2, Score3, Score4;
    public Text ScoreText;
    public int ScoreTotal = 0;

    // Use this for initialization
    void Start()
    {

        wrong1.SetActive(false);
        right1.SetActive(false);
        wrong2.SetActive(false);
        right2.SetActive(false);
        wrong3.SetActive(false);
        right3.SetActive(false);
        wrong4.SetActive(false);
        right4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Drag1()
    {
        GameObject.Find("A1").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop1()
    {
        GameObject b1 = GameObject.Find("B1");
        //GameObject b1 = Box1;
        float distance = Vector3.Distance(GameObject.Find("A1").transform.position, b1.transform.position);
        if (distance < 40)
        {

            GameObject.Find("A1").transform.position = b1.transform.position;
            Checked1 = true;
            Score1 = 2;
           // print("Drop the answer");
        }
       else if (GameObject.Find("A1").transform.position != b1.transform.position)
        {
            Checked1 = false;
            Score1 = 0;
        }
        print("Drop the answer");
    }

    public void Drag2()
    {
        GameObject.Find("A2").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop2()
    {
        GameObject wb2 = GameObject.Find("B2");
        float distance = Vector3.Distance(GameObject.Find("A2").transform.position, wb2.transform.position);
        if (distance < 40)
        {

            GameObject.Find("A2").transform.position = wb2.transform.position;
            Checked2 = true;
            Score2 = 2;
        }
        if (GameObject.Find("A2").transform.position != wb2.transform.position)
        {
            Checked2 = false;
            Score2 = 0;
        }
    }

    public void Drag3()
    {
        GameObject.Find("A3").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop3()
    {
        GameObject wb3 = GameObject.Find("B3");
        float distance = Vector3.Distance(GameObject.Find("A3").transform.position, wb3.transform.position);
        if (distance < 40)
        {

            GameObject.Find("A3").transform.position = wb3.transform.position;
            Checked3 = true;
            Score3 = 2;
        }
        if (GameObject.Find("A3").transform.position != wb3.transform.position)
        {
            Checked3 = false;
            Score3 = 0;
        }
    }

    public void Drag4()
    {
        GameObject.Find("A4").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop4()
    {
        GameObject wb4 = GameObject.Find("B4");
        float distance = Vector3.Distance(GameObject.Find("A4").transform.position, wb4.transform.position);
        if (distance < 40)
        {

            GameObject.Find("A4").transform.position = wb4.transform.position;
            Checked4 = true;
            Score4 = 2;
        }
        if (GameObject.Find("A4").transform.position != wb4.transform.position)
        {
            Checked4 = false;
            Score4 = 0;
        }
    }


    public void Submit()
    {
        if (Checked1 == true)
        {
            right1.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked1 == false)
        {
            wrong1.SetActive(true);
        }

        if (Checked2 == true)
        {
            right2.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked2 == false)
        {
            wrong2.SetActive(true);
        }

        if (Checked3 == true)
        {
            right3.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked3 == false)
        {
            wrong3.SetActive(true);
        }

        if (Checked4 == true)
        {
            right4.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked4 == false)
        {
            wrong4.SetActive(true);
        }
      

        if (Checked1 == true && Checked2 == true && Checked3 == true && Checked4 == true)
        {
            ScoreTotal = Score1 + Score2 + Score3 + Score4;

        }
        else
        {

            ScoreTotal = Score1 + Score2 + Score3 + Score4;
        }

        ScoreText.text = "SCORE :" + ScoreTotal;
    }

}
