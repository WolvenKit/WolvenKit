using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVisualTagAppearanceGroup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioVisualTagAppearanceGroup()
		{
			Appearances = new();
			VisualTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
