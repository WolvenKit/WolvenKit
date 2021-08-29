using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KerenzikovEvents : TimeDilationEventsTransitions
	{
		private CHandle<gameStatModifierData_Deprecated> _allowMovementModifier;

		[Ordinal(0)] 
		[RED("allowMovementModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AllowMovementModifier
		{
			get => GetProperty(ref _allowMovementModifier);
			set => SetProperty(ref _allowMovementModifier, value);
		}
	}
}
