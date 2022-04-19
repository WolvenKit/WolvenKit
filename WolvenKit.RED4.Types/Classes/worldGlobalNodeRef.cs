using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGlobalNodeRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public worldGlobalNodeRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
