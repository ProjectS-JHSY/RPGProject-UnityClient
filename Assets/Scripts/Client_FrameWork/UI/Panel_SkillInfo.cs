using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Client_FrameWork.UI
{
    public class Panel_SkillInfo : Panel
    {
		[SerializeField] private TMP_Text _nameText;

		[SerializeField] private TMP_Text _infoText;
		[SerializeField] private TMP_Text _levelupText;

		[SerializeField] private Slot_Skill[] _slots = new Slot_Skill[4];

		public static Panel_SkillInfo Instance = null;

		private void Awake()
		{
			Instance = this;
			gameObject.SetActive(false);
		}

		private void OnDestroy()
		{
			Instance = null;
		}

		public static void UpdateSkilList(Unit_Data data)
		{
			if (Instance != null)
			{
				Instance._updateSkillList(data);
			}
		}
		public static void UpdateSkillInfo(Skill_Data data)
		{
			if (Instance != null)
			{
				Instance._updateSkillInfo(data);
			}
		}

		public void _updateSkillList(Unit_Data data)
		{
			for(int i=0; i<data.have_skill.Count; i++)
			{
				_slots[i].UpdateSlot(GameTableData.Instance.dic_Skill[data.have_skill[i]]);
			}

			_slots[0].OnPointerClick(null);
		}

		public void _updateSkillInfo(Skill_Data data)
		{
			_nameText.text = GamePlaySytem.GetDescByID(data.skill_name_desc);
			_infoText.text = GamePlaySytem.GetDescByID(data.skill_desc);
		}


	}
}


