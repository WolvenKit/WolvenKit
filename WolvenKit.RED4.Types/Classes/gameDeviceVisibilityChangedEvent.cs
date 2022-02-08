using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceVisibilityChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isVisible")] 
		public CUInt32 IsVisible
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
