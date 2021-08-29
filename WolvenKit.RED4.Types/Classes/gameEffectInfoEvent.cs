using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectInfoEvent : redEvent
	{
		private CString _tag;
		private CUInt32 _entitiesGathered;
		private CUInt32 _entitiesFiltered;
		private CUInt32 _entitiesProcessed;

		[Ordinal(0)] 
		[RED("tag")] 
		public CString Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("entitiesGathered")] 
		public CUInt32 EntitiesGathered
		{
			get => GetProperty(ref _entitiesGathered);
			set => SetProperty(ref _entitiesGathered, value);
		}

		[Ordinal(2)] 
		[RED("entitiesFiltered")] 
		public CUInt32 EntitiesFiltered
		{
			get => GetProperty(ref _entitiesFiltered);
			set => SetProperty(ref _entitiesFiltered, value);
		}

		[Ordinal(3)] 
		[RED("entitiesProcessed")] 
		public CUInt32 EntitiesProcessed
		{
			get => GetProperty(ref _entitiesProcessed);
			set => SetProperty(ref _entitiesProcessed, value);
		}
	}
}
