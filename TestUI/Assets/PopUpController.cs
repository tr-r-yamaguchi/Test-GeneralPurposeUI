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
            Debug.LogError("ポップアップを表示するための設定がされてないため表示できません" +
                "設定した後に呼び出してください");
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
