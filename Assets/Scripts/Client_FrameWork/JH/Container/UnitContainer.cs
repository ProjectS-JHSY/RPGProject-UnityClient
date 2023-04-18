using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitContainer
{
	//플레이어가 보관하고있는 유닛(몬스터)들을 표현하기 위한 컨테이너
	public UnitContainer()
	{
		Units = new List<Unit_Data>();
	}

    public List<Unit_Data> Units { get; set;}
}
