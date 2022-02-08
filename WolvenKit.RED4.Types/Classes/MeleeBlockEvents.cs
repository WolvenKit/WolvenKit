using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MeleeBlockEvents : MeleeEventsTransition
	{
		[Ordinal(0)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}
	}
}
