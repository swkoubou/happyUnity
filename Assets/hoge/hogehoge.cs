using UnityEngine;
using System.Collections;

public class hogehoge : MonoBehaviour {
    
    
	// Use this for initialization
	void Start () {
        var i = 0;
        var a = 101;
        for (i = a; i >= 0; i = i - 2)
        {
            if (i % 2 != 0)
            {
                i--;
            }
            print(i);
        }
        
	}
	
	// Update is called once per frameS
	void Update () {
        
	}
}
