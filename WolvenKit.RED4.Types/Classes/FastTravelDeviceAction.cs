using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelDeviceAction : ActionBool
	{
		private CHandle<gameFastTravelPointData> _fastTravelPointData;

		[Ordinal(25)] 
		[RED("fastTravelPointData")] 
		public CHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetProperty(ref _fastTravelPointData);
			set => SetProperty(ref _fastTravelPointData, value);
		}
	}
}
