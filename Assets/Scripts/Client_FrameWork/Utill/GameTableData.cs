using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//모든 데이터들은 해당 데이터들을 상속받음...
public class GameTableData 
{



    public Dictionary<int, Unit_Data> dic_unitdata;
    public Dictionary<int, Desc_Data> dic_desc;
    public Dictionary<int, Skill_Data> dic_Skill;

    private static GameTableData _instance;
    public static GameTableData Instance
    {
        get
        {
            // 만약 _instance가 존재하지 않을 경우 새로 생성한다.
            if (_instance == null)
            {
                _instance = new GameTableData();
                //cur_nation_maxunitdata_list = new List<data_maxunit>();
            }
            // _instance를 반환한다.
            return _instance;
        }
    }
}
