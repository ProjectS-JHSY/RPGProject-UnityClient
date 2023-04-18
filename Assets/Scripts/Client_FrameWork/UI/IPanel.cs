using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Client_FrameWork.UI
{
	public interface IPanel
	{
		bool IsEnabled { get; set; }
		virtual void Resize() { }
		virtual void UpdatePanel() { }

	}
}
