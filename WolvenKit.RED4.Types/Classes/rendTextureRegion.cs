using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendTextureRegion : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isStretch")] 
		public CBool IsStretch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("regionParts")] 
		public CArray<rendTextureRegionPart> RegionParts
		{
			get => GetPropertyValue<CArray<rendTextureRegionPart>>();
			set => SetPropertyValue<CArray<rendTextureRegionPart>>(value);
		}

		public rendTextureRegion()
		{
			RegionParts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
