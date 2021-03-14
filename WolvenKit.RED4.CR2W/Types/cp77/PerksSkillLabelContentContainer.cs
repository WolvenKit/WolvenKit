using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		private inkTextWidgetReference _levelLabel;
		private inkWidgetReference _levelBar;
		private CHandle<ProficiencyDisplayData> _skillData;

		[Ordinal(8)] 
		[RED("levelLabel")] 
		public inkTextWidgetReference LevelLabel
		{
			get
			{
				if (_levelLabel == null)
				{
					_levelLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelLabel", cr2w, this);
				}
				return _levelLabel;
			}
			set
			{
				if (_levelLabel == value)
				{
					return;
				}
				_levelLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get
			{
				if (_levelBar == null)
				{
					_levelBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBar", cr2w, this);
				}
				return _levelBar;
			}
			set
			{
				if (_levelBar == value)
				{
					return;
				}
				_levelBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get
			{
				if (_skillData == null)
				{
					_skillData = (CHandle<ProficiencyDisplayData>) CR2WTypeManager.Create("handle:ProficiencyDisplayData", "skillData", cr2w, this);
				}
				return _skillData;
			}
			set
			{
				if (_skillData == value)
				{
					return;
				}
				_skillData = value;
				PropertySet(this);
			}
		}

		public PerksSkillLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
