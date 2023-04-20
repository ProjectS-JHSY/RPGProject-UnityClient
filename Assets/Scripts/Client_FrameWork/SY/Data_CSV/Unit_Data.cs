using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Data : BaseData
{
    public EnumType.eStarGrade unitgrade;//µÓ±ﬁ
    public EnumType.eUnittype unittype; //¿Ø¥÷≈∏¿‘
    public EnumType.eUniteletype unit_elemntType;//¿Ø¥÷ º”º∫...
    public int Desc;
    public int Unit_Hp;
    public int Unit_Atk;
    public int Unit_Def;
    public int Unit_AtkSpeed;
    public int fatality_rate;
    public int fatality_damage;
    public int effective_resistance;
    public int being_effective;
    public int set_Level;
    public int awaking;
    public bool my_char;
    public int leaderskill_id;
    public List<int> have_skill;
}
