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

    public enum eStarGrade
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
    }
    public enum eSkill_Type
    {
       Buff,
       DeBuff,
       Atk,
    }
}
