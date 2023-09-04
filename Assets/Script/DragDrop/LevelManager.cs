using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject gladiator, pantheon, dewi, air, aquadeuk, coloseum, gladiatorB,  pantheonB, dewiB, airB, aquadeukB, coloseumB, blockPanel;

    Vector3 initialGladiatorPosition, initialPantheonPosition, initialDewiPosition, initialAirPosition, initialAquaPosition, initialColoPosition;

    bool gladiatorBool, pantheonBool, dewiBool, airBool, sheepBool, coloBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    public GameObject PausePanel;
    public static bool gameIsPaused;
    void Start()
    {
        initialGladiatorPosition = gladiator.transform.position;
        initialPantheonPosition = pantheon.transform.position;
        initialDewiPosition = dewi.transform.position;
        initialAirPosition = air.transform.position;
        initialAquaPosition = aquadeuk.transform.position;
        initialColoPosition = coloseum.transform.position;
        
    }

    public void DragGladiator()
    {
        gladiator.transform.position = Input.mousePosition;     
    }

    public void DragPantheon()
    {
        pantheon.transform.position = Input.mousePosition;
    }

    public void DragDewi()
    {
        dewi.transform.position = Input.mousePosition;
    }

    public void DragAir()
    {
        air.transform.position = Input.mousePosition;
    }

    public void DragAquadeuk()
    {
        aquadeuk.transform.position = Input.mousePosition;
    }

    public void DragColoseum()
    {
        coloseum.transform.position = Input.mousePosition;
    }

    public void DropGladiator()
    {
        float distance = Vector3.Distance(gladiator.transform.position, gladiatorB.transform.position);
        if (distance < 50)
        {
            gladiator.transform.position = gladiatorB.transform.position;
            // Score.scoreNumber += 1;
            gladiatorBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            gladiator.transform.position = initialGladiatorPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropPantheon()
    {
        float distance = Vector3.Distance(pantheon.transform.position, pantheonB.transform.position);
        if (distance < 50)
        {
            pantheon.transform.position = pantheonB.transform.position;
            // Score.scoreNumber += 1;
            pantheonBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pantheon.transform.position = initialPantheonPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropDewi()
    {
        float distance = Vector3.Distance(dewi.transform.position, dewiB.transform.position);
        if (distance < 50)
        {
            dewi.transform.position = dewiB.transform.position;
            //Score.scoreNumber += 1;
            dewiBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            dewi.transform.position = initialDewiPosition;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DropAir()
    {
        float distance = Vector3.Distance(air.transform.position, airB.transform.position);
        if (distance < 50)
        {
            air.transform.position = airB.transform.position;
            //air.transform.localScale = airB.transform.localScale;
            // Score.scoreNumber += 1;
            airBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            air.transform.position = initialAirPosition;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropAquadeuk()
    {
        float distance = Vector3.Distance(aquadeuk.transform.position, aquadeukB.transform.position);
        if (distance < 50)
        {
            aquadeuk.transform.position = aquadeukB.transform.position;
           // Score.scoreNumber += 1;
            sheepBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            aquadeuk.transform.position = initialAquaPosition;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DropColoseum()
    {
        float distance = Vector3.Distance(coloseum.transform.position, coloseumB.transform.position);
        if (distance < 50)
        {
            coloseum.transform.position = coloseumB.transform.position;
            //coloseum.transform.localScale = coloseumB.transform.localScale;
            // Score.scoreNumber += 1;
            coloBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            coloseum.transform.position = initialColoPosition;
            source.clip = incorrect;
            source.Play();
        }

    }
    void Update()
    {
        if (gladiatorBool && pantheonBool && dewiBool && airBool && sheepBool && coloBool == true )//|| Timer.time <= 0)
        {
            blockPanel.SetActive(true);
        }
    }
}