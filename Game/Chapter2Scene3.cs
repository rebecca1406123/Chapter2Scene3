using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Chapter2Scene3 : MonoBehaviour
{
    public Button[] Choices;
    private UnityAction[] ChoicesFunctionToCall;

    public Button[] Thought;
    private UnityAction[] ThoughtFunctionToCall;

    public Button[] Robin;
    private UnityAction[] RobinFunctionToCall;

    public Button[] Amina;
    private UnityAction[] AminaFunctionToCall;

    public Button[] Richard;
    private UnityAction[] RichardFunctionToCall;

    public Button[] Jason;
    private UnityAction[] JasonFunctionToCall;

    public RawImage RobinRawIm;
    public Texture RobinNeutral;
    public Texture RobinSad;
    public GameObject RobinImage;

    public RawImage AminaRawIm;
    public Texture AminaNeutral;
    public Texture AminaHappy;
    public GameObject AminaImage;

    public RawImage JasonRawIm;
    public Texture JasonNeutral;
    public Texture JasonAngry;
    public GameObject JasonImage;

    public RawImage RichardRawIm;
    public Texture RichardNeutral;
    public Texture RichardAngry;
    public GameObject RichardImage;

    public GameObject Background;


    void Start()
    {

        AminaRawIm.gameObject.SetActive(false);
        JasonRawIm.gameObject.SetActive(false);
        RichardRawIm.gameObject.SetActive(false);

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            Choices[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Thought.Length; ++responseIndex)
        {
            Thought[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Robin.Length; ++responseIndex)
        {
            Robin[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Amina.Length; ++responseIndex)
        {
            Amina[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Richard.Length; ++responseIndex)
        {
            Richard[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Jason.Length; ++responseIndex)
        {
            Jason[responseIndex].gameObject.SetActive(false);
        }


        Robin[0].gameObject.SetActive(true);
        RobinRawIm.gameObject.SetActive(true);
        RobinImage.gameObject.SetActive(true);
        Background.gameObject.SetActive(true);


        ChoicesFunctionToCall = new UnityAction[]
        {
            RSpeech4, RSpeech5, RSpeech6, RSpeech13, RSpeech14, RSpeech15,
            RSpeech21, RSpeech22, RSpeech23

        };

        ThoughtFunctionToCall = new UnityAction[]
        {
            ASpeech2, ASpeech3, ASpeech4, JSpeech3, JSpeech4, JSpeech5, RiSpeech2,
            RiSpeech3, RiSpeech4
        };

        RobinFunctionToCall = new UnityAction[]
        {
            RSpeech2, RSpeech3, ASpeech1, RSpeech8, RSpeech9, RSpeech10, JSpeech1, JSpeech2,
            Choice4, Choice5, Choice6, RSpeech17, RSpeech18, RSpeech19, RiSpeech1, Choice7,
            Choice8, Choice9, RSpeech25
        };

        AminaFunctionToCall = new UnityAction[]
        {
            Choice1, Choice2, Choice3, RSpeech7, RSpeech7, RSpeech7
        };

        RichardFunctionToCall = new UnityAction[]
        {
            RSpeech20, RSpeech24, RSpeech24, RSpeech24
        };

        JasonFunctionToCall = new UnityAction[]
        {
            RSpeech11, RSpeech12, RSpeech16, RSpeech16, RSpeech16
        };


        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            AddListenerToChoices(Choices[responseIndex], ChoicesFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Robin.Length; ++responseIndex)
        {
            AddListenerToRobin(Choices[responseIndex], RobinFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Amina.Length; ++responseIndex)
        {
            AddListenerToAmina(Choices[responseIndex], AminaFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Richard.Length; ++responseIndex)
        {
            AddListenerToRichard(Choices[responseIndex], RichardFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Jason.Length; ++responseIndex)
        {
            AddListenerToJason(Choices[responseIndex], JasonFunctionToCall[responseIndex]);
        }
    }

    private void AddListenerToChoices(Button Choices, UnityEngine.Events.UnityAction ChoiceFunctionToCall)
    {
        Choices.onClick.AddListener(ChoiceFunctionToCall);
    }

    private void AddListenerToRobin(Button Robin, UnityEngine.Events.UnityAction RobinFunctionToCall)
    {
        Robin.onClick.AddListener(RobinFunctionToCall);
    }

    private void AddListenerToAmina(Button Amina, UnityEngine.Events.UnityAction AminaFunctionToCall)
    {
        Amina.onClick.AddListener(AminaFunctionToCall);
    }

    private void AddListenerToRichard(Button Richard, UnityEngine.Events.UnityAction RichardFunctionToCall)
    {
        Richard.onClick.AddListener(RichardFunctionToCall);
    }

    private void AddListenerToJason(Button Jason, UnityEngine.Events.UnityAction JasonFunctionToCall)
    {
        Jason.onClick.AddListener(JasonFunctionToCall);
    }



    void RSpeech1()
    {
        Background.gameObject.SetActive(true);
        RobinRawIm.gameObject.SetActive(true);


        Robin[0].gameObject.SetActive(true);
    }

    void RSpeech2()
    {
        Robin[0].gameObject.SetActive(false);

        Robin[1].gameObject.SetActive(true);
    }

    void RSpeech3()
    {
        Robin[1].gameObject.SetActive(false);

        Robin[2].gameObject.SetActive(true);
    }

    void ASpeech1()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[2].gameObject.SetActive(false);

        AminaRawIm.gameObject.SetActive(true);
        Amina[0].gameObject.SetActive(true);
    }

    void Choice1()
    {

    }

    void RSpeech4()
    {

    }

    void ASpeech2()
    {

    }

    void Choice2()
    {

    }

    void RSpeech5()
    {

    }

    void ASpeech3()
    {

    }

    void Choice3()
    {

    }

    void RSpeech6()
    {

    }

    void ASpeech4()
    {

    }

    void RSpeech7()
    {

    }

    void RSpeech8()
    {

    }

    void RSpeech9()
    {

    }

    void RSpeech10()
    {

    }

    void JSpeech1()
    {

    }

    void RSpeech11()
    {

    }

    void JSpeech2()
    {

    }

    void RSpeech12()
    {

    }

    void Choice4()
    {

    }

    void RSpeech13()
    {

    }

    void JSpeech3()
    {

    }

    void Choice5()
    {

    }

    void RSpeech14()
    {

    }

    void JSpeech4()
    {

    }

    void Choice6()
    {

    }

    void RSpeech15()
    {

    }

    void JSpeech5()
    {

    }

    void RSpeech16()
    {

    }

    void RSpeech17()
    {

    }

    void RSpeech18()
    {

    }

    void RSpeech19()
    {

    }

    void RiSpeech1()
    {

    }

    void RSpeech20()
    {

    }

    void Choice7()
    {

    }

    void RSpeech21()
    {

    }

    void RiSpeech2()
    {

    }

    void Choice8()
    {

    }

    void RSpeech22()
    {

    }

    void RiSpeech3()
    {

    }

    void Choice9()
    {

    }

    void RSpeech23()
    {

    }

    void RiSpeech4()
    {

    }

    void RSpeech24()
    {

    }

    void RSpeech25()
    {

    }
}