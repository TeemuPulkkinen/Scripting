using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update

    //public variable here
    public string myGameIdea;

    void Start()
    {
        print("Hello World");
        //execute new method
        PrintGame();
    }

    //create method here
    void PrintGame()
    {
        print(myGameIdea);
    }
}
