using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �|�b�v�A�b�vUI�p��View
/// </summary>
public class PopUpView : MonoBehaviour
{
    [SerializeField]
    Button yesButton = default;
    [SerializeField]
    Button noButton = default;
    [SerializeField]
    Button okButton = default;
    [SerializeField]
    TextMeshProUGUI message = default;

    public void SettingInfoUI()
    {
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
        okButton.gameObject.SetActive(true);
    }

    public void SettingConfirmUI()
    {
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
        okButton.gameObject.SetActive(false);
    }

    public void SettingMessageText(string message)
    {
        this.message.text = message;
    }
}
