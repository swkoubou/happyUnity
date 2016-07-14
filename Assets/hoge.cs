using UnityEngine;
using System.Collections;

public class hoge : MonoBehaviour
{
    public int n;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i <= n; i++)
        {
            if (i%2==0)
            {
                print(i);
            }
        }
    }
}
