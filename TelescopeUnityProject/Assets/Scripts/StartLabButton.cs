using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class StartLabButton : MonoBehaviour, IPointerClickHandler
{
    string taskText = "Перейдите к окуляру и посмотрите в него, активировав режим обозревания планет щелчком мыши по нему.";
    public GameObject textObject;
    public GameObject textPanel;
    public GameObject startButton;
    public GameObject TableButton;

    public void OnPointerClick(PointerEventData eventData)
    {
        startButton.SetActive(false);
        textPanel.SetActive(true);
        TableButton.SetActive(true);
        if (textObject.TryGetComponent(out TextMeshProUGUI message))
        {
            message.text = taskText;
            message.color = Color.black;
        }
        LabExecute.isBegan = true;
    }
}
