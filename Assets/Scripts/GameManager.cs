using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // We want to store a reference to each car in our game
    [SerializeField] private Cars racecar;
    [SerializeField] private Cars ford;
    [SerializeField] private Cars boi;

    [SerializeField] private Cars[] allcars;
    [SerializeField] private List<Cars> allcarsList = new List<Cars>();




    // Start is called before the first frame update
    void Start()
    {
        // we want to output the names of all our cars at start
        Debug.Log(allcars.Length);
        Debug.Log(allcars[0].name);

        Debug.Log(allcarsList.Count);
        Debug.Log(allcarsList[0].name);


    }

    // Update is called once per frame
    void Update()
    {
        for (int selectedCarIndex = 0; selectedCarIndex < allcarsList.Count; selectedCarIndex++)
        {
            if (allcarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("Crashed " + selectedCarIndex);
                Debug.Log("A car has carshed: [" + allcarsList[selectedCarIndex].name + "]!");

            }
            
        }

    }

    public void HelloWorldButton()
    {
        Debug.Log("Hello World From a UI button!");
    }


}
