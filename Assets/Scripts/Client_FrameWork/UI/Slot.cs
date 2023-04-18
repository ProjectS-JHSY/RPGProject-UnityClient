using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Client_FrameWork.UI
{
	public class Slot : MonoBehaviour
	{
		public RectTransform rectTransform { get { return (RectTransform)gameObject.transform; } }

		public void Display(BaseData data) { display(data); }
		protected virtual void display(BaseData data) { }

	}
}
