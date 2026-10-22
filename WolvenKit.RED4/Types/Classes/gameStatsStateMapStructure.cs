using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatsStateMapStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("keys")] 
		public CArray<gameStatsObjectID> Keys
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		[Ordinal(1)] 
		[RED("values")] 
		public CArray<gameSavedStatsData> Values
		{
			get => GetPropertyValue<CArray<gameSavedStatsData>>();
			set => SetPropertyValue<CArray<gameSavedStatsData>>(value);
		}

		[Ordinal(2)] 
		[RED("valuesOptimized")] 
		public CArray<gameSavedStatsDataOptimized> ValuesOptimized
		{
			get => GetPropertyValue<CArray<gameSavedStatsDataOptimized>>();
			set => SetPropertyValue<CArray<gameSavedStatsDataOptimized>>(value);
		}

		[Ordinal(3)] 
		[RED("sharedBufferSlices")] 
		public CArray<gameBufferSlice> SharedBufferSlices
		{
			get => GetPropertyValue<CArray<gameBufferSlice>>();
			set => SetPropertyValue<CArray<gameBufferSlice>>(value);
		}

		[Ordinal(4)] 
		[RED("sharedInactiveStats")] 
		public CArray<CEnum<gamedataStatType>> SharedInactiveStats
		{
			get => GetPropertyValue<CArray<CEnum<gamedataStatType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataStatType>>>(value);
		}

		[Ordinal(5)] 
		[RED("sharedRecordId")] 
		public CArray<TweakDBID> SharedRecordId
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(6)] 
		[RED("sharedDataBuffer")] 
		public DataBuffer SharedDataBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public gameStatsStateMapStructure()
		{
			Keys = new();
			Values = new();
			ValuesOptimized = new();
			SharedBufferSlices = new();
			SharedInactiveStats = new();
			SharedRecordId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
