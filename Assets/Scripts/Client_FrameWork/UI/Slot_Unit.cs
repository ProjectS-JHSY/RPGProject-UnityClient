using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Client_FrameWork.UI
{
	public class Slot_Unit : Slot
	{
		[SerializeField] private TMP_Text text_value;
		protected override void display(BaseData data)
		{
			text_value.text = ((Unit_Data)data).Desc.ToString();
		}
	}
}
