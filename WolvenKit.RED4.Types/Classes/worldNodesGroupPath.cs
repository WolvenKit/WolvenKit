using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNodesGroupPath : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<CName> Elements
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public worldNodesGroupPath()
		{
			Elements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
