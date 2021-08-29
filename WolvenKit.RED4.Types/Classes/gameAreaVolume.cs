using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAreaVolume : gameObject
	{
		private gameAreaData _areaData;

		[Ordinal(40)] 
		[RED("areaData")] 
		public gameAreaData AreaData
		{
			get => GetProperty(ref _areaData);
			set => SetProperty(ref _areaData, value);
		}
	}
}
