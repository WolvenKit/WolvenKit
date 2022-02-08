using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SprintEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("reloadModifier")] 
		public CHandle<gameStatModifierData_Deprecated> ReloadModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(5)] 
		[RED("isInSecondSprint")] 
		public CBool IsInSecondSprint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("sprintModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SprintModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}
	}
}
