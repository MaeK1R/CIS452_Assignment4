using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : DirectionDecorator
{
    Car car;

    public Right(Car car)
    {
        this.car = car;
    }

    public override string GetDescription()
    {
        return car.GetDescription() + " Right";
    }
}
