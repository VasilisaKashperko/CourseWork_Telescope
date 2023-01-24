using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOcularus : MonoBehaviour
{
    public static void NextToOcularus(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
