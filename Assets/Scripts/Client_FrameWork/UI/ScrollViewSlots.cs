using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Client_FrameWork.UI
{
	public class ScrollViewSlots : ScrollRect
	{
		[Header("ScrollView Slots")]
		[SerializeField] private Vector2 margin;
		[SerializeField] Slot[] slots;

		protected override void OnEnable()
		{
			slots[0].OnPointerClick(null);
		}

		protected override void Awake()
		{
			base.Awake();
			slots = new Slot[content.childCount];

			for(int i = 0; i < slots.Length; i++)
			{
				slots[i] = content.GetChild(i).GetComponent<Slot>();
			}
		}

		public void UpdateData(List<BaseData> datas)
		{
			for (int i = 0; i < slots.Length; i++)
			{
				if (i < datas.Count)
					slots[i].UpdateSlot(datas[i]);
			}
		}
	}
}
