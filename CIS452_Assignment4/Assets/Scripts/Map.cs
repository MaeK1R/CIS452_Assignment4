using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    public string check;
    // Start is called before the first frame update
    void Start()
    {
        SetDirections();
    }

    public void SetDirections()
    {
        check = "";
        int temp = Random.Range(0, 2);

        if (temp == 1)
            check += "Red ";
        else
            check += "Blue ";

        for (int i = 0; i < 3; i++)
        {
            temp = Random.Range(0, 3);

            if (temp == 0)
                check += "Left ";
            else if (temp == 1)
                check += "Straight ";
            else if (temp == 2)
                check += "Right ";

        }
        gameObject.GetComponent<Text>().text = check;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
