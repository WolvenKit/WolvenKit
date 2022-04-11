using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleVisibleObjectComponent : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("componentTargetState")] 
		public CBool ComponentTargetState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("visibleObjectDescription")] 
		public CName VisibleObjectDescription
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ToggleVisibleObjectComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
