using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarInteraction : MonoBehaviour
{
    [SerializeField] private InputField yearInputField;
    [SerializeField] private InputField makeInputField;
    [SerializeField] private TMP_Text carDisplayText;
    [SerializeField] private Button submitButton;
    private bool carExists;
    private Car playerCar;
    
    // Start is called before the first frame update
    void Start()
    {
        CreateCar(2001,"butt");
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
        submitButton.onClick.AddListener(() =>CreateCar(0,"butt"));
    }

    void CreateCar(int year, string make)
    {
        if (year <= 2024 && year >= 1886)
        {
            if (make != "")
            {
                playerCar = new Car(year, make);
                carExists = true;
            }
            else
            {
                Debug.Log("Make field is empty");
            }
        }
        else
        {
            Debug.Log("Invalid year");
            //Todo:display year error
            //Todo: clear input field
        }
    }
    
}
