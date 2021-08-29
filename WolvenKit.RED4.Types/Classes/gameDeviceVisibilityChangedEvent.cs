using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceVisibilityChangedEvent : redEvent
	{
		private CUInt32 _isVisible;

		[Ordinal(0)] 
		[RED("isVisible")] 
		public CUInt32 IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}
	}
}
