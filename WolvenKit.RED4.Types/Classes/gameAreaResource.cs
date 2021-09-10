using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAreaResource : CResource
	{
		[Ordinal(1)] 
		[RED("cookedData")] 
		public CArray<gameCookedAreaData> CookedData
		{
			get => GetPropertyValue<CArray<gameCookedAreaData>>();
			set => SetPropertyValue<CArray<gameCookedAreaData>>(value);
		}

		public gameAreaResource()
		{
			CookedData = new();
		}
	}
}
