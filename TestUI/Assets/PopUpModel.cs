using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpModel : MonoBehaviour
{
    [SerializeField]
    PopUpController.PopUpType popUpType = default;
    [SerializeField]
    string messageText = default;

    public PopUpController.PopUpType ShowPopUpType => popUpType;

    public string MessageText => messageText;
}
