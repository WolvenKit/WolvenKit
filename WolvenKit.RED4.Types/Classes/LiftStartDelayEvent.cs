using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftStartDelayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetFloor")] 
		public CInt32 TargetFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
