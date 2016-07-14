using UnityEngine;
using System.Collections;

public class samplehiro : MonoBehaviour {
	public int n;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < n; i += 2)
			print (i);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
