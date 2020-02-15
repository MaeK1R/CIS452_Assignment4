using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : DirectionDecorator
{
    Car car;

    public Left(Car car)
    {
        this.car = car;
    }

    public override string GetDescription()
    {
        return car.GetDescription() + " Left";
    }
}
