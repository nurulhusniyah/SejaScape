using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void ChangeScene(string changethescene)
    {
        SceneManager.LoadScene(changethescene);
    }
}