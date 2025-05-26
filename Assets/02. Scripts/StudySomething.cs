using UnityEngine;

public class StudySomething : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;

    void Start()
    {
       //string msg = currentLevel >= maxLevel ? "ÇöÀç ¸¸·¾ÀÔ´Ï´Ù." : "ÇöÀç ¸¸·¾ÀÌ ¾Æ´Õ´Ï´Ù.";

        int levelPoint = currentLevel >= maxLevel ? 0 : 1;

        currentLevel += levelPoint;


        //Debug.Log(msg);
    }

}