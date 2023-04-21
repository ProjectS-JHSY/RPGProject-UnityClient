using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

namespace Client_FrameWork.UI
{
	public class Slot_Skill : Slot
	{
		public static bool Seclected { get { return selectedSlot != null; } }
		static Slot_Skill selectedSlot = null;

		[SerializeField] private Image highlight;
		[SerializeField] private Image icon;
		[SerializeField] private TMP_Text level_text;
		private Skill_Data _data;


		protected override void updateSlot(BaseData data)
		{
			var isNull = (data != null);

			if (isNull)
			{
				var _data = (Skill_Data)data;
				this._data = _data;

				//TODO : icon spirte 변경
				icon.sprite = Util_Standard.Load_resource_Skill_Sprites(_data.skill_icon);
			}

			level_text.gameObject.SetActive(isNull);
			icon.gameObject.SetActive(isNull);
			
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
			if(GamePlaySytem.UpdateSkillInfo(_data))
			{
				if (selectedSlot != null)
					selectedSlot.UnFocus();

				selectedSlot = this;
				highlight.color = Color.yellow;
			}
		}

		public void UnFocus()
		{
			selectedSlot = null;
			highlight.color = Color.white;
		}
	}
}