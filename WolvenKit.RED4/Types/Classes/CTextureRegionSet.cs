using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CTextureRegionSet : CResource
	{
		[Ordinal(1)] 
		[RED("regions")] 
		public CArray<rendTextureRegion> Regions
		{
			get => GetPropertyValue<CArray<rendTextureRegion>>();
			set => SetPropertyValue<CArray<rendTextureRegion>>(value);
		}

		public CTextureRegionSet()
		{
			Regions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
