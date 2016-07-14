using UnityEngine;
using System.Collections;

public class samplehiro : MonoBehaviour {
	public int n;
	int i=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (i < n) {
			print(i * 2);
			i++;
		}
	}
}
