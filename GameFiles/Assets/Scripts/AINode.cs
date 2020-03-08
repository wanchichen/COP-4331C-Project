﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AINode : MonoBehaviour
{
    // Array of weights to each connection
    public int[] weights;

    // Array of numbers corresponding to connected nodes
    public int[] connections;

    // Value of the node
    private float output;

    // Node input (for input layer nodes only)
    private float input;

    // Check for if input node
    private bool isInputLayer;


    // Access output
    public float GetOutput()
    {
        return output;
    }

    // Set input (for input layer nodes)
    public void SetInput(float value)
    {
        input = value;
        isInputLayer = true;
    }
}
