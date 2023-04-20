using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Client_FrameWork.UI
{
	public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
	{
		public RectTransform rectTransform { get { return (RectTransform)gameObject.transform; } }

		public void Display(BaseData data) { display(data); }

		public virtual void OnPointerClick(PointerEventData eventData) { }
		public virtual void OnPointerEnter(PointerEventData eventData) { }
		public virtual void OnPointerExit(PointerEventData eventData) { }

		protected virtual void display(BaseData data) { }

	}
}
