using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVisualTagToNPCMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("foleyNPCMetadata")] 
		public CName FoleyNPCMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioVisualTagToNPCMetadata()
		{
			VisualTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
