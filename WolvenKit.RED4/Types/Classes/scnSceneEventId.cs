using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneEventId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnSceneEventId()
		{
			Id = long.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
