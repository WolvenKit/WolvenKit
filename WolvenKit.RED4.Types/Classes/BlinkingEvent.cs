using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlinkingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requestNumber")] 
		public CInt32 RequestNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
