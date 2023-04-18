using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Client_FrameWork.UI
{
	public class Panel : MonoBehaviour, IPanel
	{
		private Vector2 firstPos;

		private void Awake()
		{
			firstPos = transform.localPosition;
			gameObject.SetActive(false);
		}

		public bool IsEnabled
		{
			set
			{
				if(value)
					((RectTransform)transform).localPosition = Vector2.zero;
				else
					((RectTransform)transform).localPosition = firstPos;

				gameObject.SetActive(value);
			}

			get
			{
				return true;
			}
		}
		public virtual void Resize() { }
		public virtual void UpdatePanel() { }

	}
}
