using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Client_FrameWork.UI;

public class GamePlaySytem : MonoBehaviour
{
    EnumType.eGameStatus gametype;

    private static GamePlaySytem _instance;
    public static GamePlaySytem Instance

    {
        get
        {
            // ���� _instance�� �������� ���� ��� ���� �����Ѵ�.
            if (_instance == null)
            {
                _instance = new GamePlaySytem();
                //cur_nation_maxunitdata_list = new List<data_maxunit>();
            }
            // _instance�� ��ȯ�Ѵ�.
            return _instance;
        }
    }

    public static bool UpdateUnitInfo(Unit_Data data)
	{
        if(data != null)
            Panel_UnitInfo.UpdateInfo(data);

        return (data != null);
	}

    public static string GetDescByID(int id)
    {
        return GameTableData.Instance.dic_desc[id].Desc;
    }

    public static string GetStringByType(EnumType.eUnittype type)
    {
        switch (type)
        {
            case EnumType.eUnittype.Combattype:
                return "전투형";
            case EnumType.eUnittype.supporttype:
                return "지원형";
            case EnumType.eUnittype.defensivetype:
                return "방어형";
            default:
                return "타입없음";
        }
    }

    private void Awake()
    {

        GameTableData.Instance.dic_unitdata = CSVReader.Read_Unit_data("Unit_data.csv");
        GameTableData.Instance.dic_desc = CSVReader.Read_Desc_data("Desc_data.csv");

        switch (gametype)
        {
            case EnumType.eGameStatus.none:
                break;
            case EnumType.eGameStatus.read_data:
              
                break;
            case EnumType.eGameStatus.set_object:
                break;
            case EnumType.eGameStatus.Loading:
                break;
            case EnumType.eGameStatus.play:
                break;
            case EnumType.eGameStatus.suspend:
                break;
            default:
                break;
        }


       
        run_createtiles();

       // GameEventManager.OnEvent_GameStatus += addreaddata; ����
    }

    //private void addreaddata(EnumType.eGameStatus _gameStatus) ����
    //{
    //    switch (_gameStatus)
    //    {
    //        case EnumType.eGameStatus.read_data:
    //            GameTableData.Instance.dic_unitdata = CSVReader.Read_Unit_data("Unit_data.csv");
    //            break;
    //    }
    //}

    private Coroutine cor_waitfor_createtile;
    private void run_createtiles()
    {
        if (cor_waitfor_createtile != null) StopCoroutine(cor_waitfor_createtile);
        cor_waitfor_createtile = StartCoroutine("cor_process_create");
    }

    private IEnumerator cor_process_create()
    {
        int totalloadingcount = 6;
        int curlodedent = 0;

        while (totalloadingcount > curlodedent)
        {
            if (curlodedent == 0)//.data_read
            {
               // GameEventManager.Send_GameStatusEvent(EnumType.eGameStatus.read_data);
            }
            else if(curlodedent == 1)//.create object
            {

            }
            else if (curlodedent == 2)//event....
            {

            }
            else if (curlodedent == 3)
            {

            }
            else if (curlodedent == 4)
            {

            }
            else if (curlodedent == 5)
            {

            }
            else if (curlodedent == 6)
            {

            }
            curlodedent++;
        }
        

        yield return null;
    }
}
