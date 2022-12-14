using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //変数の個数が５のint型の配列arrayを宣言して好きな値で初期化する。
        int[] array = { 1, 3, 5, 7, 9 };

        
        //for文を使い、配列の各要素の値を順番に表示する
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        
        //for文を使い、配列の各要素の値を逆順に表示する
        for(int i= array.Length-1; i>=0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題
        //Magic関数を呼び出して、魔法を使ってください
        //Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示することを確認してください
        Boss zako = new Boss();
        /*zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        zako.Magic(5);
        */
        for(int i = 11; i>=0; i--)
        {
            if (i > 0)
            {
                zako.Magic(5);
            }
        }


    }

    //発展課題
    //Lesson4で作成したBossクラスをもとに作成してください

    public class Boss
    {

        //int型の変数mpを宣言し、53で初期化してください
        int mp = 53;
        //mpを消費して魔法攻撃をするMagic関数を作ってください
        public void Magic(int use)
        {
            this.mp -= use;
            if (this.mp > 0)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }



        //練習
        //コンソールに変数の中身を表示
        //Debug.Log("Hellow World");

        /*
                //変数の宣言
                int score;
                //変数の代入
                score = 150;
                //コンソールに変数の中身を表示
                Debug.Log(score);


                //足し算
                int a = 3;
                int b = 4;
                int c = a + b;
                Debug.Log(c);
        */

        /* if文
        int money = 200;

        if (money >= 100)
        {
            //moneyが100以上なら、文字列を表示する
            Debug.Log("ポーションを買うために"+money+"円支払った");

        }
        */

        /*
        //if else文
        int money = 50;

        if (money >= 100)
        {
            Debug.Log("ポーションを買う");

        }
        else
        {
            Debug.Log("武器を売る");
        }
        */

        /*if else if文
        int money = 300;
        if (money <= 50)
        {
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            Debug.Log("武器を買う");

        }
        else
        {
            Debug.Log("ポーションを買う");
        }

        */

        /*
        //三項演算子
        int num = 1;
        int val = (num == 1) ? -100 : 100;
        Debug.Log(val);
        */

        /*
         //for文
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        */

        /*for文を使って1から10まで合計をする
        int sum = 0;
        for (int i= 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        */

        /*
        //配列

        int[] points = new int[5];

        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        for(int i = 0; i < 5; i++)
        {
           Debug.Log(points[i]);
        }
        */

        /*
        string[] points = new string[5];

        points[0] = "たかし";
        points[1] = "けいすけ";
        points[2] = "なみ";
        points[3] = "堂安";
        points[4] = "伊藤";

        for(int i=0; i<5; i++)
        {
            Debug.Log(points[i]);
        }
        */

        /*
        int[] points = { 30, 20, 10, 3, 23, 45, 67, 73, 54 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 50)
            {
                Debug.Log(points[i]);
            }
        }
        */



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
