using UnityEngine;
using System.Collections;

public class counter : MonoBehaviour {
    public int count = 0;

	
	void Start () {
	    for(int i = 1; i < count; i++)
        {
            if(i % 2 == 0)
                Debug.Log(i);
        }
	}
	
	
	void Update () {
	    
	}
}
