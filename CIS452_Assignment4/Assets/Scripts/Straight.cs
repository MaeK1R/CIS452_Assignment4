using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : DirectionDecorator
{
    Car car;

    public Straight(Car car)
    {
        this.car = car;
    }

    public override string GetDescription()
    {
        return car.GetDescription() + " Straight";
    }
}