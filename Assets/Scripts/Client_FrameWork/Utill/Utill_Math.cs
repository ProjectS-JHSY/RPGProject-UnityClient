using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

//utill함수... 새로운 new를 쓰지말고 해당 클래스에 만들어져있는 스태틱 변수를 쓰면 최적화에 엄청난 도움이됨..
public static class Utill_Math 
{
    public static WaitForSeconds waitSecOPOOFive = new WaitForSeconds(0.005f);
    public static WaitForSeconds waitSecOPOOne = new WaitForSeconds(0.01f);
    public static WaitForSeconds waitSecOPOTwo = new WaitForSeconds(0.02f);
    public static WaitForSeconds waitSecOPOThree = new WaitForSeconds(0.03f);
    public static WaitForSeconds waitSecOPOFour = new WaitForSeconds(0.04f);
    public static WaitForSeconds waitSecOPOFive = new WaitForSeconds(0.05f);

    public static WaitForSeconds waitSecOPOne = new WaitForSeconds(0.1f);
    public static WaitForSeconds waitSecOPTwo = new WaitForSeconds(0.2f);
    public static WaitForSeconds waitSecOPTwoFive = new WaitForSeconds(0.25f);
    public static WaitForSeconds waitSecOPThree = new WaitForSeconds(0.3f);
    public static WaitForSeconds waitSecOPThreeFive = new WaitForSeconds(0.35f);
    public static WaitForSeconds waitSecOPThreeFour = new WaitForSeconds(0.4f);
    public static WaitForSeconds waitSecOPFive = new WaitForSeconds(0.5f);
    public static WaitForSeconds waitSecOpSix = new WaitForSeconds(0.6f);
    public static WaitForSeconds waitSecOnePSeven = new WaitForSeconds(0.7f);
    public static WaitForSeconds waitSecOne = new WaitForSeconds(1);
    public static WaitForSeconds waitSecOnepOne = new WaitForSeconds(1.1f);
    public static WaitForSeconds waitSecOnePtwo = new WaitForSeconds(1.2f);
    public static WaitForSeconds waitSecOnePthree = new WaitForSeconds(1.3f);
    public static WaitForSeconds waitSecOnePFive = new WaitForSeconds(1.5f);
    public static WaitForSeconds waitSecOnePSix = new WaitForSeconds(1.6f);
    public static WaitForSeconds waitSecTwo = new WaitForSeconds(2);
    public static WaitForSeconds waitSecTwoPfive = new WaitForSeconds(2.5f);
    public static WaitForSeconds waitSecThree = new WaitForSeconds(3);
    public static WaitForSeconds waitSecThreePfive = new WaitForSeconds(3.5f);
    public static WaitForSeconds waitSecFour = new WaitForSeconds(4f);
    public static WaitForSeconds waitSecFive = new WaitForSeconds(5);
    public static WaitForSeconds waitSecSix = new WaitForSeconds(6);
    public static WaitForSeconds waitSecTen = new WaitForSeconds(10);
    public static WaitForSeconds waitSecSixty = new WaitForSeconds(60);
    public static Vector3[] coinSpriteSizes = new Vector3[2] { new Vector3(0.48f, 0.48f, 1), new Vector3(1f, 1f, 1) };
    public static Vector2 onev2 = Vector2.one;
    public static Vector3 onev3 = Vector3.one;
    public static Vector3 zeronv3 = Vector3.zero;
    public static Vector2 zeronv2 = Vector2.zero;

    public static string tofromtZero(int _val)
    {
        string str = String.Format("0,,,.###B", _val);
        return str;
    }
}
