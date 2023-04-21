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

    //게임 구성에 필요한 text를 desc_id로 매칭시켜 불러옴...
    public enum Desc_Txt
    {

    }

    public enum eGrade
    {
        normal,
        Rare,
        Epic,
        Legend,
    }


    public enum eUnittype
    {
        Combattype,
        supporttype,
        defensivetype,
    }

    public enum eUniteletype
    {
        Fire,
        Water,
        Earth,
        Light,
        darkness,
    }
    //해당 enum에 할당된 값들은 해당 등급들의 MaxLevel..
    public enum eStarGrade
    {
        One = 15,
        Two = 20, 
        Three = 25,
        Four = 30,
        Five = 35,
        Six = 40,
    }
    public enum eSkill_Type
    {
       Buff,
       DeBuff,
       Atk,
    }

    public enum eWorld_Status
    {
        Cloesd,
        Open,
        Clear,
    }

}
