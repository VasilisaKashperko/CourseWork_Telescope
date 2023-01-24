using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class CompleteLabRepeat : MonoBehaviour, IPointerClickHandler
{
    public void NextToOcularus(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (LabExecute.isSized)
        {
            NextToOcularus(0);
        }
    }
}
