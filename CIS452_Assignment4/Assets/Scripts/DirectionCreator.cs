using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionCreator : MonoBehaviour
{
    public Car car;
    int temp;
    int count = 0;
    public int score = 0;
    public GameObject Score;
    public Map map;
    // Start is called before the first frame update
    void Start()
    {
        temp = Random.Range(0, 2);
        if (temp == 0)
        {
            SetCar("Red");
        }
        else
            SetCar("Blue");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AddDirection("Left");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddDirection("Straight");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            AddDirection("Right");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (temp == 0)
            {
                SetCar("Blue");
                temp = 1;
                count = 0;
            }
            else
            {
                SetCar("Red");
                temp = 0;
                count = 0;

            }

        }

    }
    public void SetCar(string newCar)
    {
        switch (newCar)
        {
            case "Red":
                this.car = new BlueCar();
                break;
            case "Blue":
                this.car = new RedCar();
                break;
        }
        DisplayCar();
    }
    public void AddDirection(string newDirection)
    {
        switch (newDirection)
        {
            case "Left":
                this.car = new Left(car);
                break;
            case "Straight":
                this.car = new Straight(car);
                break;
            case "Right":
                this.car = new Right(car);
                break;
        }
        count++;
        if (count == 3)
        {
            Compare();
            map.SetDirections();
        }
           


        DisplayCar();
    }
    public void DisplayCar()
    {
        gameObject.GetComponent<Text>().text = car.GetDescription();
    }
    public void Compare()
    {
        if (car.GetDescription().Trim().Equals(map.check.Trim()))
        {
            Debug.Log("win");
            score++;
            Score.GetComponent<Text>().text = "Score: " + score;
        }
        else
            Debug.Log("lose");
    }
}
