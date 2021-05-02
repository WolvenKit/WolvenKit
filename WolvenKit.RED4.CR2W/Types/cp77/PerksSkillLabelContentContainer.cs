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
			get => GetProperty(ref _levelLabel);
			set => SetProperty(ref _levelLabel, value);
		}

		[Ordinal(9)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get => GetProperty(ref _levelBar);
			set => SetProperty(ref _levelBar, value);
		}

		[Ordinal(10)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get => GetProperty(ref _skillData);
			set => SetProperty(ref _skillData, value);
		}

		public PerksSkillLabelContentContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
