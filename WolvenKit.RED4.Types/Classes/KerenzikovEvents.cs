using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KerenzikovEvents : TimeDilationEventsTransitions
	{
		[Ordinal(0)] 
		[RED("allowMovementModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AllowMovementModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}
	}
}
