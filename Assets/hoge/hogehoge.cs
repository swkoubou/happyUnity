using UnityEngine;
using System.Collections;

public class hogehoge : MonoBehaviour {
    public int i = 0;
    public int a = 100;
	// Use this for initialization
	void Start () {
     
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
