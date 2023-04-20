using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitContainer
{
	//플레이어가 보관하고있는 유닛(몬스터)들을 표현하기 위한 컨테이너
	public UnitContainer()
	{
		_units = new List<Unit_Data>();
	}

	public static UnitContainer Instance
	{
		get
		{
			if(_instance == null)
				_instance = new UnitContainer();

			return _instance;
		}
		set { _instance = value; }
	}
	private static UnitContainer _instance;

	public static List<Unit_Data> Units
	{
		get { return Instance._units;}
		set { Instance._units = value; }
	}

    private List<Unit_Data> _units { get; set;}
}
