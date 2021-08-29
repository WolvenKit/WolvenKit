using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAreaResource : CResource
	{
		private CArray<gameCookedAreaData> _cookedData;

		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedAreaData> CookedData
		{
			get => GetProperty(ref _cookedData);
			set => SetProperty(ref _cookedData, value);
		}
	}
}
