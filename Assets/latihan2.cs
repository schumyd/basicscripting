using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class latihan2 : MonoBehaviour {

	public int nilaiA;
	public int nilaiB;
	 [Range(1, 5)]
	 public int nilaiC;
	void Start () 
	{
		int total = (nilaiA + nilaiB) * nilaiC;
		Debug.Log("Total " + total);		
	}
	
	void Update () {
		
	}
}
