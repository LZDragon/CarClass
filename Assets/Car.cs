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

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public string GetMake()
    {
        return make;
    }

    public void SetMake(string make)
    {
        this.make = make;
    }

    public void Accelerate(int rate)
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
