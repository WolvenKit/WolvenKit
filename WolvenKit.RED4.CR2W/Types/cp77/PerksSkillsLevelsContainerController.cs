using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelsContainerController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _topRowItemsContainer;
		private inkCompoundWidgetReference _bottomRowItemsContainer;
		private inkWidgetReference _levelBar;
		private inkWidgetReference _levelBarSpacer;
		private inkTextWidgetReference _label;
		private CHandle<ProficiencyDisplayData> _proficiencyDisplayData;

		[Ordinal(1)] 
		[RED("topRowItemsContainer")] 
		public inkCompoundWidgetReference TopRowItemsContainer
		{
			get => GetProperty(ref _topRowItemsContainer);
			set => SetProperty(ref _topRowItemsContainer, value);
		}

		[Ordinal(2)] 
		[RED("bottomRowItemsContainer")] 
		public inkCompoundWidgetReference BottomRowItemsContainer
		{
			get => GetProperty(ref _bottomRowItemsContainer);
			set => SetProperty(ref _bottomRowItemsContainer, value);
		}

		[Ordinal(3)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get => GetProperty(ref _levelBar);
			set => SetProperty(ref _levelBar, value);
		}

		[Ordinal(4)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetProperty(ref _levelBarSpacer);
			set => SetProperty(ref _levelBarSpacer, value);
		}

		[Ordinal(5)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(6)] 
		[RED("proficiencyDisplayData")] 
		public CHandle<ProficiencyDisplayData> ProficiencyDisplayData
		{
			get => GetProperty(ref _proficiencyDisplayData);
			set => SetProperty(ref _proficiencyDisplayData, value);
		}

		public PerksSkillsLevelsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
