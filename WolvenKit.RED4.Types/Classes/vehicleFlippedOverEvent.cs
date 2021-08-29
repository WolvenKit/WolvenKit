using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleFlippedOverEvent : redEvent
	{
		private CBool _isFlippedOver;

		[Ordinal(0)] 
		[RED("isFlippedOver")] 
		public CBool IsFlippedOver
		{
			get => GetProperty(ref _isFlippedOver);
			set => SetProperty(ref _isFlippedOver, value);
		}
	}
}
