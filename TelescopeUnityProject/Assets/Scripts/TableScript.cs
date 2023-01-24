using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TableScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject Elements;

    public UnityEngine.UI.Image TableImage;
    public UnityEngine.UI.InputField Input1;
    public UnityEngine.UI.InputField Input2;
    public UnityEngine.UI.InputField Input3;
    public UnityEngine.UI.InputField Input4;
    public UnityEngine.UI.InputField Input5;
    public UnityEngine.UI.InputField Input6;

    void Start()
    {
        TableImage.enabled = false;
        Elements.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (TableImage.enabled == true)
        {
            LabExecute.inputP1 = $"{Input1.text}";
            LabExecute.inputP2 = $"{Input2.text}";
            LabExecute.inputP3 = $"{Input3.text}";
            LabExecute.inputP4 = $"{Input4.text}";
            LabExecute.inputP5 = $"{Input5.text}";
            LabExecute.inputP6 = $"{Input6.text}";

            TableImage.enabled = false;
            Elements.SetActive(false);
        }
        else
        {
            TableImage.enabled = true;
            Elements.SetActive(true);

            LabExecute.inputP1 = $"{Input1.text}";
            LabExecute.inputP2 = $"{Input2.text}";
            LabExecute.inputP3 = $"{Input3.text}";
            LabExecute.inputP4 = $"{Input4.text}";
            LabExecute.inputP5 = $"{Input5.text}";
            LabExecute.inputP6 = $"{Input6.text}";
        }
    }
}
