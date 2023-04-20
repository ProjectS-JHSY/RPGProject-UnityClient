using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Client_FrameWork.UI
{
    public class Panel_UnitInfo : Panel
    {
		[SerializeField] private TMP_Text _nameText;

		[SerializeField] private TMP_Text _infoText;
		[SerializeField] private TMP_Text _typeText;

		[SerializeField] private TabButton _tabButton;

		[SerializeField] private Image _eleIcon;
		[SerializeField] private Sprite _fireIcon;
		[SerializeField] private Sprite _waterIcon;
		[SerializeField] private Sprite _earthIcon;
		[SerializeField] private Sprite _lightIcon;
		[SerializeField] private Sprite _darkIcon;

		public static Panel_UnitInfo Instance = null;

		private void Awake()
		{
			Instance = this;
			gameObject.SetActive(false);
		}

		private void OnDestroy()
		{
			Instance = null;
		}

		public static void UpdateInfo(Unit_Data data)
		{
			if (Instance != null)
			{
				Instance.UpdateText(data);
			}
		}

		public void UpdateText(Unit_Data data)
		{
			if(!Slot_Unit.Seclected)
				_tabButton.OnPointerClick();

			_nameText.text = GamePlaySytem.GetDescByID(data.Desc);
			_typeText.text = GamePlaySytem.GetStringByType(data.unittype);

			switch(data.unit_elemntType)
			{
				case EnumType.eUniteletype.Fire:
					_eleIcon.sprite = _fireIcon;
					break;
				case EnumType.eUniteletype.Water:
					_eleIcon.sprite = _waterIcon;
					break;
				case EnumType.eUniteletype.Earth:
					_eleIcon.sprite = _earthIcon;
					break;
				case EnumType.eUniteletype.Light:
					_eleIcon.sprite = _lightIcon;
					break;
				case EnumType.eUniteletype.darkness:
					_eleIcon.sprite = _darkIcon;
					break;
				default:
					_eleIcon.sprite = null;
					break;
			}


			StringBuilder text = new StringBuilder();

			text.AppendFormat("\n{0}\n{1}\n{2}\n{3}\n\n{4}%\n{5}%\n{6}%\n{7}%", data.Unit_Hp, data.Unit_Atk, data.Unit_Def, data.Unit_AtkSpeed, data.fatality_rate, data.fatality_damage, data.effective_resistance, data.being_effective);
			_infoText.text = text.ToString();
		}


	}
}


