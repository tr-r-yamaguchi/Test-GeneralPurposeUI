using System;
using UnityEngine;

public class PopUpController : MonoBehaviour
{
    public enum PopUpType
    {
        Info,
        Confirm
    }

    enum SetUpState
    {
        Unset,
        Set
    }

    [SerializeField]
    PopUpView popUpView = default;
    [SerializeField]
    PopUpModel popUpModel = default;

    SetUpState currentSetUpState = SetUpState.Unset;

    public void SetUp(PopUpType type,string popUpMessage)
    {
        if (type == PopUpType.Info)
        {
            popUpView.SettingInfoUI();
        }
        else if (type == PopUpType.Confirm)
        {
            popUpView.SettingConfirmUI();
        }

        popUpView.SettingMessageText(popUpMessage);

        currentSetUpState = SetUpState.Set;

    }

    public void DisplayPopUp()
    {
        if (currentSetUpState == SetUpState.Unset)
        {
            Debug.LogError("�|�b�v�A�b�v��\�����邽�߂̐ݒ肪����ĂȂ����ߕ\���ł��܂���" +
                "�ݒ肵����ɌĂяo���Ă�������");
            return;
        }

        gameObject.SetActive(true);
    }

    //void Start()
    //{
    //    if (popUpModel.ShowPopUpType == PopUpType.Info)
    //    {
    //        popUpView.SettingInfoUI();
    //    }
    //    else if (popUpModel.ShowPopUpType == PopUpType.Confirm)
    //    {
    //        popUpView.SettingConfirmUI();
    //    }

    //    popUpView.SettingMessageText(popUpModel.MessageText);
    //}
}
