using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TabGroup : MonoBehaviour 
{
	private TabButton selectedTab = null;
	private List<TabButton> tabButtons = new List<TabButton>();
	[SerializeField] private List<GameObject> tabContents = new List<GameObject>();

	[SerializeField] private Color _normalColor;
	[SerializeField] private Color _hoverColor;
	[SerializeField] private Color _selectedColor;

	public void Subscribe(TabButton button)
	{
		tabButtons.Add(button);
	}

	public void OnTabEnter(TabButton button)
	{
		resetTabButtons();
		if (selectedTab == null || button != selectedTab)
			button.BackgroundColor = _hoverColor;
	}

	public void OnTabClick(TabButton button)
	{
		selectedTab = button;
		resetTabButtons();
		button.BackgroundColor = _selectedColor;

		int index = button.transform.GetSiblingIndex();

		for(int i = 0; i < tabContents.Count; i++)
		{
			tabContents[i].SetActive(i == index);
		}

	}

	public void OnTabExit(TabButton button)
	{
		resetTabButtons();
	}

	private void resetTabButtons()
	{
		foreach(TabButton button in tabButtons)
		{
			if(selectedTab != null && button == selectedTab)
				continue;
			button.BackgroundColor = _normalColor;
		}
	}

}
