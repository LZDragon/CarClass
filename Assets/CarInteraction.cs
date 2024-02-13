using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarInteraction : MonoBehaviour
{
    [SerializeField] private InputField yearInputField;
    [SerializeField] private InputField makeInputField;
    [SerializeField] private Text carDisplayText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            Debug.Log("Accelerate");
        }
        if (Input.GetKeyDown("down"))
        {
            Debug.Log("Decelerate");
        }
    }
}
