using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Client_FrameWork.UI
{
	public class Panel_PopUp : MonoBehaviour, IPanel
	{

		public bool IsEnabled
		{
			set
			{
				if(value)
				{
					//do nothing
				}
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
