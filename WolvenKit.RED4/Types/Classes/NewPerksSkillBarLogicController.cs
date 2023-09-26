using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksSkillBarLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("statsProgressWidget")] 
		public inkWidgetReference StatsProgressWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("levelsContainer")] 
		public inkCompoundWidgetReference LevelsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("data")] 
		public CHandle<ProficiencyDisplayData> Data
		{
			get => GetPropertyValue<CHandle<ProficiencyDisplayData>>();
			set => SetPropertyValue<CHandle<ProficiencyDisplayData>>(value);
		}

		[Ordinal(21)] 
		[RED("requestedSkills")] 
		public CInt32 RequestedSkills
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("statsProgressController")] 
		public CWeakHandle<StatsProgressController> StatsProgressController
		{
			get => GetPropertyValue<CWeakHandle<StatsProgressController>>();
			set => SetPropertyValue<CWeakHandle<StatsProgressController>>(value);
		}

		[Ordinal(23)] 
		[RED("levelsControllers")] 
		public CArray<CWeakHandle<NewPerksSkillLevelLogicController>> LevelsControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<NewPerksSkillLevelLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NewPerksSkillLevelLogicController>>>(value);
		}

		public NewPerksSkillBarLogicController()
		{
			StatsProgressWidget = new inkWidgetReference();
			LevelsContainer = new inkCompoundWidgetReference();
			LevelsControllers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
