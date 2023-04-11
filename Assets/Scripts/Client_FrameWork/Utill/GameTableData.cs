using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//: 작성작 :sy
//: csv의 data를 이곳의 데이터 변수에 전부 담아두는 클래스...
public class GameTableData
{
    public Dictionary<int, Unit_Data> dic_Unit;


    private static GameTableData _instance;
    public static GameTableData Instance
    {
        get
        {
            // 만약 _instance가 존재하지 않을 경우 새로 생성한다.
            if (_instance == null)
            {
                _instance = new GameTableData();
            }
            // _instance를 반환한다.
            return _instance;
        }
    }
}
