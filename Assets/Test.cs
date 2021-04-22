using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic(int tairyoku)
    {
        if (mp >= 5)
        {
            mp -= tairyoku;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("mpが足りないため魔法が使えない");
        }

    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame upd
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }
        lastboss.Magic(5);

        int[] array = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
