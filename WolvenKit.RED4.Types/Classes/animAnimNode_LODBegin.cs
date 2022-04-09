using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LODBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("levelOfDetail")] 
		public CUInt32 LevelOfDetail
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_LODBegin()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
