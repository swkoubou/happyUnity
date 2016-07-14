using UnityEngine;
using System.Collections;

public class counter : MonoBehaviour {
    public int count = 0;
    private int i = 0;
	
	void Start () {
        //第一弾
	    /*for(int i = 1; i < count; i++)
        {
            if(i % 2 == 0)
                Debug.Log(i);
        }*/
	}
	
	
	void Update () {
        //第二弾
        if (i == count)
            return;

        i++;
        if (i % 2 == 0)
            Debug.Log(i);
    }
}
