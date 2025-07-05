using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneInstanceOwnerId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnSceneInstanceOwnerId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
