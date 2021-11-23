using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : IBuild
{
    public string name;
    public int floor;
    public Build(string name)
    {
        this.name = name;
    }

    public void AddFloor()
    {
        floor++;
    }
    public void AddFloor(int multiplier)
    {
        floor += multiplier;
    }

    public void AddGarage()
    {
        Debug.Log("Added garage.");
    }

    public void AddGarden()
    {
        Debug.Log("Added garden.");
    }
}