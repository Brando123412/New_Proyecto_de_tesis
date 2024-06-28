using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    private void Start()
    {
        inputField.GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener(x => OpenKeyBoard());
    }
    public void OpenKeyBoard()
    {
        NonNativeKeyboard.Instance.InputField = inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);
    }
}