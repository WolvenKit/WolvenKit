using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInfoEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CString Tag
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("entitiesGathered")] 
		public CUInt32 EntitiesGathered
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("entitiesFiltered")] 
		public CUInt32 EntitiesFiltered
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("entitiesProcessed")] 
		public CUInt32 EntitiesProcessed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameEffectInfoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
