using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAutomatic : MonoBehaviour
{
    [Header("Text Labels")]
    [SerializeField] private TextMeshProUGUI instructionLabel = null;
    [SerializeField] private GameObject nextButton;
    [SerializeField] private GameObject previousButton;

    // Start is called before the first frame update
    public void DisplayInstruction(string instruction)
    {
        
        instructionLabel.SetText(instruction);
    }

    public void HidePreviousButton() 
    {
        previousButton.SetActive(false);
    }

    public void HideNextButton()
    {
        nextButton.SetActive(false);
    }

    public void DisplayButtons()
    {
        previousButton.SetActive(true);
        nextButton.SetActive(true);
    }
}
