using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Client_FrameWork.UI;

namespace Client_FrameWork.Controller
{
    public class UnitController : MonoBehaviour
    {
        //GameTableData에 저장된 유닛정보를 가지고
        //UnitContainer에 유닛을 등록하고 관리하는 역할.

        [SerializeField] private ScrollViewSlots _Unitslots;


        public void RegisterUnit(int id)
        {
            UnitContainer.Units.Add(GameTableData.Instance.dic_unitdata[id]);

            List<BaseData> unitDataList = UnitContainer.Units.ConvertAll<BaseData>(data => data as BaseData);
            _Unitslots.UpdateData(unitDataList);
        }
        public void RegisterUnit(Unit_Data unit)
		{
            UnitContainer.Units.Add(unit);
		}

        public void RemoveUnit()
		{
            //remove unit
		}
	}
}

