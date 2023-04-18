using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumType
{
    public enum eGameStatus
    {
        none,
        read_data,
        set_object,
        Loading,
        play,
        suspend,
    }


    public enum eGrade
    {
        normal,
        Rare,
        Epic,
        Legend,
    }

}
