using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRelativeNodePath : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parentsToSkip")] 
		public CUInt32 ParentsToSkip
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<worldRelativeNodePathElement> Elements
		{
			get => GetPropertyValue<CArray<worldRelativeNodePathElement>>();
			set => SetPropertyValue<CArray<worldRelativeNodePathElement>>(value);
		}

		public worldRelativeNodePath()
		{
			Elements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
