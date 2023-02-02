using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksSkillsLevelsContainerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("topRowItemsContainer")] 
		public inkCompoundWidgetReference TopRowItemsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bottomRowItemsContainer")] 
		public inkCompoundWidgetReference BottomRowItemsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("proficiencyDisplayData")] 
		public CHandle<ProficiencyDisplayData> ProficiencyDisplayData
		{
			get => GetPropertyValue<CHandle<ProficiencyDisplayData>>();
			set => SetPropertyValue<CHandle<ProficiencyDisplayData>>(value);
		}

		public PerksSkillsLevelsContainerController()
		{
			TopRowItemsContainer = new();
			BottomRowItemsContainer = new();
			LevelBar = new();
			LevelBarSpacer = new();
			Label = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
