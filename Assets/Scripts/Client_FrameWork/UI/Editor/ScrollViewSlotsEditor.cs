using UnityEditor;
using UnityEditor.UI;

namespace Client_FrameWork.UI
{
	[CustomEditor(typeof(ScrollViewSlots),true)]
	public class ScrollViewSlotsEditor : ScrollRectEditor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
		}
	}
}
