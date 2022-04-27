using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resPathHash")] 
		public CUInt64 ResPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnSceneId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
