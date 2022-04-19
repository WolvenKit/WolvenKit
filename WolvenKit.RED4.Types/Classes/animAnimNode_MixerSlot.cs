using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MixerSlot : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("maxNormalAnimEntriesCount")] 
		public CUInt16 MaxNormalAnimEntriesCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(13)] 
		[RED("maxAdditiveAnimEntriesCount")] 
		public CUInt16 MaxAdditiveAnimEntriesCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(14)] 
		[RED("maxOverrideAnimEntriesCount")] 
		public CUInt16 MaxOverrideAnimEntriesCount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public animAnimNode_MixerSlot()
		{
			Id = 4294967295;
			InputLink = new();
			MaxNormalAnimEntriesCount = 2;
			MaxAdditiveAnimEntriesCount = 2;
			MaxOverrideAnimEntriesCount = 2;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
