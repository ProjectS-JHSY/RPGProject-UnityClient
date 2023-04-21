using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

namespace Client_FrameWork.UI
{
	public class Slot_Unit : Slot
	{
		public static bool Seclected { get { return selectedSlot != null; } }
		static Slot_Unit selectedSlot = null;

		[SerializeField] private Image highlight;
		[SerializeField] private Image icon;

		[SerializeField] private TMP_Text level_text;
		protected override void updateSlot(BaseData data)
		{
			var isNull = (data != null);

			if (isNull)
			{
				var _data = (Unit_Data)data;
				level_text.text = _data.set_Level.ToString();
				//TODO : icon spirte 변경
				icon.sprite = Util_Standard.Load_resource_Unit_Sprites(_data.id);
			}

			level_text.gameObject.SetActive(isNull);
			icon.gameObject.SetActive(isNull);
			
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
			if(selectedSlot != this || selectedSlot == null)
			{
				if(GamePlaySytem.UpdateUnitInfo(UnitContainer.Units[transform.GetSiblingIndex()]))
				{
					if (selectedSlot != null)
						selectedSlot.UnFocus();

					selectedSlot = this;
					highlight.color = Color.yellow;

					GamePlaySytem.UpdateSkillList(UnitContainer.Units[transform.GetSiblingIndex()]);
				}
			}
			
		}

		public void UnFocus()
		{
			selectedSlot = null;
			highlight.color = Color.white;
		}
	}
}