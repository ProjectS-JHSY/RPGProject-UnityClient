using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Client_FrameWork.UI
{
	public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
	{
		private TabGroup _tabGroup;
		private Image _background;

		public Color BackgroundColor
		{
			set
			{
				_background.color = value;
			}
		}

		private void Awake()
		{
			_background = GetComponent<Image>();
			_tabGroup = transform.parent.GetComponent<TabGroup>();
		}

		private void Start()
		{
			_tabGroup.Subscribe(this);
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			_tabGroup.OnTabEnter(this);
		}

		public void OnPointerClick(PointerEventData eventData)
		{
			_tabGroup.OnTabClick(this);
		}

		public void OnPointerClick()
		{
			_tabGroup.OnTabClick(this);
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			_tabGroup.OnTabExit(this);
		}
	}
}

