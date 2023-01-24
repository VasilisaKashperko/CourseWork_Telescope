using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class OcularInterface : MonoBehaviour
{

    [SerializeField]
    private Text message;
    [SerializeField]
    private Text message1;
    [SerializeField]
    private Text message2;
    [SerializeField]
    private Text message3;
    [SerializeField]
    private Text message4;
    [SerializeField]
    private Text message5;
    [SerializeField]
    private Text message6;
    [SerializeField]
    private Text message7;
    [SerializeField]
    private Text choose;
    [SerializeField]
    private Text Return;
    [SerializeField]
    private Text messageInfo;

    public UnityEngine.UI.Image Rules;
    public UnityEngine.UI.Image Planet1;
    public UnityEngine.UI.Image Planet2;
    public UnityEngine.UI.Image Planet3;
    public UnityEngine.UI.Image Planet4;
    public UnityEngine.UI.Image Planet5;
    public UnityEngine.UI.Image Planet6;
    public UnityEngine.UI.Image Planet7;
    public UnityEngine.UI.Image RulesInfo;
    public UnityEngine.UI.Image planetMap;
    public UnityEngine.UI.Image planetMapFon;

    public GameObject ListPlanet;
    public GameObject buttonToTelescope;

    public void Start()
    {
        Rules.enabled = false;
        message.enabled = false;
        message.color = Color.white;

        Planet1.enabled = false;
        Planet2.enabled = false;
        Planet3.enabled = false;
        Planet4.enabled = false;
        Planet5.enabled = false;
        Planet6.enabled = false;
        Planet7.enabled = false;

        message1.enabled = false;
        message2.enabled = false;
        message3.enabled = false;
        message4.enabled = false;
        message5.enabled = false;
        message6.enabled = false;
        message7.enabled = false;
        ListPlanet.gameObject.SetActive(false);
        choose.enabled = false;

        Return.enabled = false;
        buttonToTelescope.gameObject.SetActive(false);

        planetMap.enabled = false;
        planetMapFon.enabled = false;
        messageInfo.enabled = false;
        RulesInfo.enabled = false;
    }

    public void OnClickHelp()
    {
        message.fontSize = 28;
        message.color = Color.white;
        message.fontStyle = FontStyle.Bold;
        message.text = "Идентификация планеты";
        if (Rules.enabled == true)
        {
            Rules.enabled = false;
            message.enabled = false;
            Planet1.enabled = false;
            Planet2.enabled = false;
            Planet3.enabled = false;
            Planet4.enabled = false;
            Planet5.enabled = false;
            Planet6.enabled = false;
            Planet7.enabled = false;
            message1.enabled = false;
            message2.enabled = false;
            message3.enabled = false;
            message4.enabled = false;
            message5.enabled = false;
            message6.enabled = false;
            message7.enabled = false;
            ListPlanet.gameObject.SetActive(false);
            choose.enabled = false;
            Return.enabled = false;
            buttonToTelescope.gameObject.SetActive(false);
        }
        else
        {
            Rules.enabled = true;
            message.enabled = true;
            Planet1.enabled = true;
            Planet2.enabled = true;
            Planet3.enabled = true;
            Planet4.enabled = true;
            Planet5.enabled = true;
            Planet6.enabled = true;
            Planet7.enabled = true;
            message1.enabled = true;
            message2.enabled = true;
            message3.enabled = true;
            message4.enabled = true;
            message5.enabled = true;
            message6.enabled = true;
            message7.enabled = true;
            ListPlanet.gameObject.SetActive(true);
            choose.enabled = true;
            Return.enabled = true;
            buttonToTelescope.gameObject.SetActive(true);
        }
    }

    public void OnClickINFO()
    {
        messageInfo.fontSize = 28;
        messageInfo.color = Color.white;
        messageInfo.text = "Для управления оптической трубой телескопа используйте клавиши W, S, A, D:\n\n" +
            "W - вверх\n" +
            "S - вниз\n" +
            "A - влево\n" +
            "D - вправо\n" +
            "\n" +
            "В помощь при навигации можете использовать карту положения планет:";
        if (RulesInfo.enabled == true)
        {
            RulesInfo.enabled = false;
            messageInfo.enabled = false;
            planetMap.enabled = false;
            planetMapFon.enabled = false;
        }
        else
        {
            RulesInfo.enabled = true;
            messageInfo.enabled = true;
            planetMap.enabled = true;
            planetMapFon.enabled = true;
        }
    }
}