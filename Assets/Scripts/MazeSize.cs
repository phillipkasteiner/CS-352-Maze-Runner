﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeSize : MonoBehaviour {

	public int xAxis = 5;
	public int yAxis = 5;
	public Text X;
	public Text Y;

	// Use this for initialization
	void Start () {
		
	}

	public void MinusX (int x) {
		if (xAxis > 5) {
			xAxis--;
		}
		X.text = xAxis.ToString();
	}

	public void PlusX (int x) {
		xAxis++;
		X.text = xAxis.ToString();
	}

	public void MinusY(int y) {
		if (yAxis > 5)
        {
			yAxis--;
        }
		Y.text = yAxis.ToString();
    }

	public void PlusY (int y) {
		yAxis++;
		Y.text = yAxis.ToString();
	}

	public int GetXAxis() {
		return xAxis;
	}

	public int GetYAxis() {
		return yAxis;
    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
