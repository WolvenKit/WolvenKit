using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SprintEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("reloadModifier")] 
		public CHandle<gameStatModifierData_Deprecated> ReloadModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(8)] 
		[RED("isInSecondSprint")] 
		public CBool IsInSecondSprint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("sprintModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SprintModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public SprintEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
