using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSnapTags : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("includeTags")] 
		public CArray<CName> IncludeTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("excludeTags")] 
		public CArray<CName> ExcludeTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public worldSnapTags()
		{
			IncludeTags = new() { "generic" };
			ExcludeTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
