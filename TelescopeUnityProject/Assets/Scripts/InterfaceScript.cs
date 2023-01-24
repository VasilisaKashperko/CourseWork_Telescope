using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;
using TMPro;

public class InterfaceScript : MonoBehaviour
{
    public GameObject textObject;
    public GameObject textPanel;
    public GameObject textPanelSharpen;
    public GameObject startButton;
    public GameObject sharpnessButton;
    public GameObject ElementsTable;
    public GameObject TableButton;
    public GameObject Elements;

    public UnityEngine.UI.Image TableImage;
    public UnityEngine.UI.Image Rules;
    public UnityEngine.UI.Image sharpnessTable;

    public UnityEngine.UI.InputField Input1;
    public UnityEngine.UI.InputField Input2;
    public UnityEngine.UI.InputField Input3;
    public UnityEngine.UI.InputField Input4;
    public UnityEngine.UI.InputField Input5;
    public UnityEngine.UI.InputField Input6;

    [SerializeField]
    private Text message;
    [SerializeField]
    private Text nameT;
    [SerializeField]
    private Text sharpnessT;
    [SerializeField]
    private Text massT;
    [SerializeField]
    private Text diameterT;
    [SerializeField]
    private Text sizeT;
    [SerializeField]
    private Text nameT2;
    [SerializeField]
    private Text sharpnessT2;
    [SerializeField]
    private Text massT2;
    [SerializeField]
    private Text diameterT2;
    [SerializeField]
    private Text sizeT2;
    [SerializeField]
    private Text nameT3;
    [SerializeField]
    private Text sharpnessT3;
    [SerializeField]
    private Text massT3;
    [SerializeField]
    private Text diameterT3;
    [SerializeField]
    private Text sizeT3;
    [SerializeField]
    private Text nameT4;
    [SerializeField]
    private Text sharpnessT4;
    [SerializeField]
    private Text massT4;
    [SerializeField]
    private Text diameterT4;
    [SerializeField]
    private Text sizeT4;
    [SerializeField]
    private Text nameT5;
    [SerializeField]
    private Text sharpnessT5;
    [SerializeField]
    private Text massT5;
    [SerializeField]
    private Text diameterT5;
    [SerializeField]
    private Text sizeT5;
    [SerializeField]
    private Text nameT6;
    [SerializeField]
    private Text sharpnessT6;
    [SerializeField]
    private Text massT6;
    [SerializeField]
    private Text diameterT6;
    [SerializeField]
    private Text sizeT6;

    string taskText = "Перейдите к окуляру и настройте резкость для планеты " + LabExecute.planetName + ", воспользовавшись справочными значениями.";

    public void Start()
    {
        ElementsTable.SetActive(false);
        TableImage.enabled = false;
        Rules.enabled = false;
        message.enabled = false;

        if (LabExecute.isTheEnd)
        {
            LabExecute.isPlanetFounded = false;
            LabExecute.isBegan = false;
            LabExecute.isSharpnessOK = false;
            LabExecute.isBeganPart2 = false;
            LabExecute.isSharpnessCheck = false;

            if (LabExecute.experimentsAmount == 1)
            {
                LabExecute.planetNameP1 = LabExecute.planetName;
                LabExecute.printSharpP1 = LabExecute.printSharp;
                LabExecute.valueMassP1 = LabExecute.valueMass;
                LabExecute.valueDiameterP1 = LabExecute.valueDiameter;
                LabExecute.upsizeP1 = LabExecute.upsize;
            }
            if (LabExecute.experimentsAmount == 2)
            {
                LabExecute.planetNameP2 = LabExecute.planetName;
                LabExecute.printSharpP2 = LabExecute.printSharp;
                LabExecute.valueMassP2 = LabExecute.valueMass;
                LabExecute.valueDiameterP2 = LabExecute.valueDiameter;
                LabExecute.upsizeP2 = LabExecute.upsize;
            }
            if (LabExecute.experimentsAmount == 3)
            {
                LabExecute.planetNameP3 = LabExecute.planetName;
                LabExecute.printSharpP3 = LabExecute.printSharp;
                LabExecute.valueMassP3 = LabExecute.valueMass;
                LabExecute.valueDiameterP3 = LabExecute.valueDiameter;
                LabExecute.upsizeP3 = LabExecute.upsize;
            }

            if (LabExecute.experimentsAmount == 4)
            {
                LabExecute.planetNameP4 = LabExecute.planetName;
                LabExecute.printSharpP4 = LabExecute.printSharp;
                LabExecute.valueMassP4 = LabExecute.valueMass;
                LabExecute.valueDiameterP4 = LabExecute.valueDiameter;
                LabExecute.upsizeP4 = LabExecute.upsize;
            }

            if (LabExecute.experimentsAmount == 5)
            {
                LabExecute.planetNameP5 = LabExecute.planetName;
                LabExecute.printSharpP5 = LabExecute.printSharp;
                LabExecute.valueMassP5 = LabExecute.valueMass;
                LabExecute.valueDiameterP5 = LabExecute.valueDiameter;
                LabExecute.upsizeP5 = LabExecute.upsize;
            }

            LabExecute.isTheEnd = false;

            Rules.enabled = false;
            message.enabled = false;
            sharpnessTable.enabled = false;
            message.color = Color.white;
            TableButton.SetActive(false);
            Elements.SetActive(false);
            sharpnessButton.SetActive(false);

            LabExecute.planetName = "";
            LabExecute.printSharp = "";
            LabExecute.valueMass = "";
            LabExecute.valueDiameter = "";
            LabExecute.upsize = "";
        }

        sharpnessTable.enabled = false;
        message.color = Color.white;
        TableButton.SetActive(false);
        Elements.SetActive(false);
        sharpnessButton.SetActive(false);

        if (LabExecute.experimentsAmount == 0)
        {
            nameT.text = LabExecute.planetName;
            sharpnessT.text = LabExecute.printSharp;
            massT.text = LabExecute.valueMass;
            diameterT.text = LabExecute.valueDiameter;
            sizeT.text = LabExecute.upsize;
            Input1.text = LabExecute.inputP1;
        }

        if (LabExecute.experimentsAmount == 1)
        {
            nameT.text = LabExecute.planetNameP1;
            sharpnessT.text = LabExecute.printSharpP1;
            massT.text = LabExecute.valueMassP1;
            diameterT.text = LabExecute.valueDiameterP1;
            sizeT.text = LabExecute.upsizeP1;
            Input1.text = LabExecute.inputP1;

            nameT2.text = LabExecute.planetName;
            sharpnessT2.text = LabExecute.printSharp;
            massT2.text = LabExecute.valueMass;
            diameterT2.text = LabExecute.valueDiameter;
            sizeT2.text = LabExecute.upsize;
            Input2.text = LabExecute.inputP2;
        }

        if (LabExecute.experimentsAmount == 2)
        {
            nameT.text = LabExecute.planetNameP1;
            sharpnessT.text = LabExecute.printSharpP1;
            massT.text = LabExecute.valueMassP1;
            diameterT.text = LabExecute.valueDiameterP1;
            sizeT.text = LabExecute.upsizeP1;
            Input1.text = LabExecute.inputP1;

            nameT2.text = LabExecute.planetNameP2;
            sharpnessT2.text = LabExecute.printSharpP2;
            massT2.text = LabExecute.valueMassP2;
            diameterT2.text = LabExecute.valueDiameterP2;
            sizeT2.text = LabExecute.upsizeP2;
            Input2.text = LabExecute.inputP2;

            nameT3.text = LabExecute.planetName;
            sharpnessT3.text = LabExecute.printSharp;
            massT3.text = LabExecute.valueMass;
            diameterT3.text = LabExecute.valueDiameter;
            sizeT3.text = LabExecute.upsize;
            Input3.text = LabExecute.inputP3;
        }

        if (LabExecute.experimentsAmount == 3)
        {
            nameT.text = LabExecute.planetNameP1;
            sharpnessT.text = LabExecute.printSharpP1;
            massT.text = LabExecute.valueMassP1;
            diameterT.text = LabExecute.valueDiameterP1;
            sizeT.text = LabExecute.upsizeP1;
            Input1.text = LabExecute.inputP1;

            nameT2.text = LabExecute.planetNameP2;
            sharpnessT2.text = LabExecute.printSharpP2;
            massT2.text = LabExecute.valueMassP2;
            diameterT2.text = LabExecute.valueDiameterP2;
            sizeT2.text = LabExecute.upsizeP2;
            Input2.text = LabExecute.inputP2;

            nameT3.text = LabExecute.planetNameP3;
            sharpnessT3.text = LabExecute.printSharpP3;
            massT3.text = LabExecute.valueMassP3;
            diameterT3.text = LabExecute.valueDiameterP3;
            sizeT3.text = LabExecute.upsizeP3;
            Input3.text = LabExecute.inputP3;

            nameT4.text = LabExecute.planetName;
            sharpnessT4.text = LabExecute.printSharp;
            massT4.text = LabExecute.valueMass;
            diameterT4.text = LabExecute.valueDiameter;
            sizeT4.text = LabExecute.upsize;
            Input4.text = LabExecute.inputP4;
        }

        if (LabExecute.experimentsAmount == 4)
        {
            nameT.text = LabExecute.planetNameP1;
            sharpnessT.text = LabExecute.printSharpP1;
            massT.text = LabExecute.valueMassP1;
            diameterT.text = LabExecute.valueDiameterP1;
            sizeT.text = LabExecute.upsizeP1;
            Input1.text = LabExecute.inputP1;

            nameT2.text = LabExecute.planetNameP2;
            sharpnessT2.text = LabExecute.printSharpP2;
            massT2.text = LabExecute.valueMassP2;
            diameterT2.text = LabExecute.valueDiameterP2;
            sizeT2.text = LabExecute.upsizeP2;
            Input2.text = LabExecute.inputP2;

            nameT3.text = LabExecute.planetNameP3;
            sharpnessT3.text = LabExecute.printSharpP3;
            massT3.text = LabExecute.valueMassP3;
            diameterT3.text = LabExecute.valueDiameterP3;
            sizeT3.text = LabExecute.upsizeP3;
            Input3.text = LabExecute.inputP3;

            nameT4.text = LabExecute.planetNameP4;
            sharpnessT4.text = LabExecute.printSharpP4;
            massT4.text = LabExecute.valueMassP4;
            diameterT4.text = LabExecute.valueDiameterP4;
            sizeT4.text = LabExecute.upsizeP4;
            Input4.text = LabExecute.inputP4;

            nameT5.text = LabExecute.planetName;
            sharpnessT5.text = LabExecute.printSharp;
            massT5.text = LabExecute.valueMass;
            diameterT5.text = LabExecute.valueDiameter;
            sizeT5.text = LabExecute.upsize;
            Input5.text = LabExecute.inputP5;
        }

        if (LabExecute.experimentsAmount == 5)
        {
            nameT.text = LabExecute.planetNameP1;
            sharpnessT.text = LabExecute.printSharpP1;
            massT.text = LabExecute.valueMassP1;
            diameterT.text = LabExecute.valueDiameterP1;
            sizeT.text = LabExecute.upsizeP1;
            Input1.text = LabExecute.inputP1;

            nameT2.text = LabExecute.planetNameP2;
            sharpnessT2.text = LabExecute.printSharpP2;
            massT2.text = LabExecute.valueMassP2;
            diameterT2.text = LabExecute.valueDiameterP2;
            sizeT2.text = LabExecute.upsizeP2;
            Input2.text = LabExecute.inputP2;

            nameT3.text = LabExecute.planetNameP3;
            sharpnessT3.text = LabExecute.printSharpP3;
            massT3.text = LabExecute.valueMassP3;
            diameterT3.text = LabExecute.valueDiameterP3;
            sizeT3.text = LabExecute.upsizeP3;
            Input3.text = LabExecute.inputP3;

            nameT4.text = LabExecute.planetNameP4;
            sharpnessT4.text = LabExecute.printSharpP4;
            massT4.text = LabExecute.valueMassP4;
            diameterT4.text = LabExecute.valueDiameterP4;
            sizeT4.text = LabExecute.upsizeP4;
            Input4.text = LabExecute.inputP4;

            nameT5.text = LabExecute.planetNameP5;
            sharpnessT5.text = LabExecute.printSharpP5;
            massT5.text = LabExecute.valueMassP5;
            diameterT5.text = LabExecute.valueDiameterP5;
            sizeT5.text = LabExecute.upsizeP5;
            Input5.text = LabExecute.inputP5;

            nameT6.text = LabExecute.planetName;
            sharpnessT6.text = LabExecute.printSharp;
            massT6.text = LabExecute.valueMass;
            diameterT6.text = LabExecute.valueDiameter;
            sizeT6.text = LabExecute.upsize;
            Input6.text = LabExecute.inputP6;
        }

        if (LabExecute.isPlanetFounded)
        {
            startButton.SetActive(false);
            textPanel.SetActive(true);
            textPanelSharpen.SetActive(true);
            sharpnessButton.SetActive(true);
            TableButton.SetActive(true);
            if (textObject.TryGetComponent(out TextMeshProUGUI message))
            {
                message.text = taskText;
                message.color = Color.black;
            }
        }
    }

    public void OnSettings()
    {
        message.fontSize = 24;
        message.color = Color.white;
        message.text = "Для передвижения по комнате с установкой \"Телескоп\" используются клавиши W, S, A, D:\r\n\n" +
            "Клавиши W/S - передвижение вверх и вниз относительно плоскости экрана\r\n" +
            "Клавиши A/D - передвижение влево и вправо относительно плоскости экрана\r\n\n" +
            "Колесо мыши - приближение\r\n" +
            "Удериживание правой кнопки мыши - вращение вокруг установки\r\n" +
            "\n"+
            "\n"+
            "Для дальнейшей и более удобной навигации по установке рекомендуется использовать кнопки навигации.\r\n" +
            "Нажите на кнопку \"Навигация по установке\" - перед вами появится список элементов установки.\r\n" +
            "При наведении на кнопку нужный элемент будет подсвечиваться, при нажатии - камера переходит к удобному расположению в окне приложения для просмотра нахождения элемента.\r\n" +
            "\n" +
            "Для начала выполнения заданий нажмите на кнопку \"Начать работу с телескопом\".\r\n" +
            "";
        if (Rules.enabled == true)
        {
            Rules.enabled = false;
            message.enabled = false;
        }
        else
        {
            Rules.enabled = true;
            message.enabled = true;
        }
    }

    public void SharpnessInfo()
    {
        message.fontSize = 24;
        message.color = Color.white;
        message.text = "Справочные значения настройки резкости окуляра для планет\n";
        if (Rules.enabled == true)
        {
            Rules.enabled = false;
            message.enabled = false;
            sharpnessTable.enabled = false;
        }
        else
        {
            Rules.enabled = true;
            message.enabled = true;
            sharpnessTable.enabled = true;
        }
    }

    [System.Obsolete]
    public void ShowElements()
    {
       if (Elements.active == true)
           Elements.SetActive(false);
       else Elements.SetActive(true);
    }
}