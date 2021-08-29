using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CTextureRegionSet : CResource
	{
		private CArray<rendTextureRegion> _regions;

		[Ordinal(1)] 
		[RED("regions")] 
		public CArray<rendTextureRegion> Regions
		{
			get => GetProperty(ref _regions);
			set => SetProperty(ref _regions, value);
		}
	}
}
