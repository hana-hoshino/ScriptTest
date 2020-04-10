using UnityEngine;
using System.Collections;
using System;



public class Boss
{
    private int mp = 53;   // 魔力

    // Magic関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            // 残りmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            //mpが足りない場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}



public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            // Magic関数を呼び出す
            boss.Magic();
        }
        
        


        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        // 配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // 配列の要素を逆順に表示する
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}