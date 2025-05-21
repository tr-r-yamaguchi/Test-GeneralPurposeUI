using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI : MonoBehaviour
{
    [SerializeField]
    GameObject popUpUIPrefab = default;
    PopUpController popUpController;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            GameObject popUp = Instantiate(popUpUIPrefab, transform);
            popUpController = popUp.GetComponent<PopUpController>();
            popUpController.SetUp
        }
    }
}
