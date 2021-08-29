using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleWaterEvent : redEvent
	{
		private CBool _isInWater;

		[Ordinal(0)] 
		[RED("isInWater")] 
		public CBool IsInWater
		{
			get => GetProperty(ref _isInWater);
			set => SetProperty(ref _isInWater, value);
		}
	}
}
