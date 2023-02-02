using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatusEffect : gameStatusEffectBase
	{
		[Ordinal(1)] 
		[RED("durationID")] 
		public CUInt32 DurationID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("remainingDuration")] 
		public CFloat RemainingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxStacks")] 
		public CUInt32 MaxStacks
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("sourcesData")] 
		public CArray<gameSourceData> SourcesData
		{
			get => GetPropertyValue<CArray<gameSourceData>>();
			set => SetPropertyValue<CArray<gameSourceData>>(value);
		}

		[Ordinal(6)] 
		[RED("initialApplicationTimestamp")] 
		public CFloat InitialApplicationTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lastApplicationTimestamp")] 
		public CFloat LastApplicationTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(9)] 
		[RED("instigatorRecordID")] 
		public TweakDBID InstigatorRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(10)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(11)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("removeAllStacksWhenDurationEnds")] 
		public CBool RemoveAllStacksWhenDurationEnds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("applicationSource")] 
		public CName ApplicationSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameStatusEffect()
		{
			DurationID = 4294967295;
			Duration = -1.000000F;
			RemainingDuration = -1.000000F;
			MaxStacks = 2147483647;
			SourcesData = new();
			OwnerEntityID = new();
			InstigatorEntityID = new();
			Direction = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
