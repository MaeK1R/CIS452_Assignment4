using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car
{
    public string description = "Unknown Vehicle";

    public virtual string GetDescription()
    {
        return description;
    }

}