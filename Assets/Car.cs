//////////////////////////////////////////////
//Assignment/Lab/Project: Car Class
//Name: Eliza Majernik
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 2/19/2024
/////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{

    private int year;
    private string make;
    private readonly int maxSpeed;
    private int currentSpeed;


    public Car(int year, string make)
    {
        this.year = year;
        this.make = make;
        currentSpeed = 0;
        maxSpeed = 100;
    }

    public string Make
    {
        get => make;
        set => make = value;
    }

    public int Year
    {
        get => year;
        set => year = value;
    }
    

    public void Accelerate(byte rate)
    {
        if ((currentSpeed + rate) >= maxSpeed)
        {
            currentSpeed = maxSpeed;
        }
        else
        {
            currentSpeed += rate;
        }
    }

    public void Decelerate(int rate)
    {
        if ((currentSpeed - rate) <= 0)
        {
            currentSpeed = 0;
        }
        else
        {
            currentSpeed -= rate;
        }
    }


    public override string ToString()
    {
        return $"Year: {year}, Make: {make}, Current Speed: {currentSpeed}";
    }
}
