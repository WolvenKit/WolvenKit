using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsSpawnEntityEventParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(2)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackData")] 
		public CArray<scneventsSpawnEntityEventFallbackData> FallbackData
		{
			get => GetPropertyValue<CArray<scneventsSpawnEntityEventFallbackData>>();
			set => SetPropertyValue<CArray<scneventsSpawnEntityEventFallbackData>>(value);
		}

		public scneventsSpawnEntityEventParams()
		{
			Performer = new scnPerformerId { Id = 4294967040 };
			ReferencePerformer = new scnPerformerId { Id = 4294967040 };
			FallbackData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
