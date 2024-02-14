using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarInteraction : MonoBehaviour
{
    [SerializeField] private TMP_InputField yearInputField;
    [SerializeField] private TMP_InputField makeInputField;
    [SerializeField] private TMP_Text carDisplayText;
    [SerializeField] private Button submitButton;
    [SerializeField] private GameObject inputUI;
    [SerializeField] private TMP_Text errorText;
    private bool carExists;
    private Car playerCar;
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayUserPrompt();
    }

    // Update is called once per frame
    void Update()
    {
        if (carExists)
        {
            if (Input.GetKey("up"))
            {
                Debug.Log("Accelerate");
                playerCar.Accelerate(1);
                carDisplayText.text = playerCar.ToString();
            }
            if (Input.GetKey("down"))
            {
                Debug.Log("Decelerate");
                playerCar.Decelerate(1);
                carDisplayText.text = playerCar.ToString();
            }
        }
    }

    void DisplayUserPrompt()
    {
        inputUI.SetActive(true);
        submitButton.onClick.AddListener(ValidateInput);
    }

    void ValidateInput()
    {
        int year = int.Parse(yearInputField.text);
        string make = makeInputField.text;
        if (year <= 2024 && year >= 1886)
        {
            if (make != "")
            {   
                CreateCar(year,make);
                inputUI.SetActive(false);
            }
            else
            {
                Debug.Log("Make field is empty");
                errorText.text = "Make field is empty";
            }
        }
        else
        {
            Debug.Log("Invalid year");
            errorText.text = "Invalid year: year must be between 1886 and 2024";
            yearInputField.text = "";
        }
    }

    void CreateCar(int year, string make)
    {
        playerCar = new Car(year, make);
        Debug.Log("Car Made");
        carExists = true;
        carDisplayText.text = playerCar.ToString();
        carDisplayText.gameObject.SetActive(true);
    }
    
    
}
