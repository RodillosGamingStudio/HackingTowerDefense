using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 1000;

    public static int Lives;
    public int startLives = 20;

    public static int StolenData;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        StolenData = 0;

    }

}
