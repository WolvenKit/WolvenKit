using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_VisualizerComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("records")] 
		public CArray<DEBUG_VisualRecord> Records
		{
			get => GetPropertyValue<CArray<DEBUG_VisualRecord>>();
			set => SetPropertyValue<CArray<DEBUG_VisualRecord>>(value);
		}

		[Ordinal(6)] 
		[RED("offsetCounter")] 
		public CInt32 OffsetCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("processedRecordIndex")] 
		public CInt32 ProcessedRecordIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("showWeaponsStreaming")] 
		public CBool ShowWeaponsStreaming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("TICK_TIME_DELTA")] 
		public CFloat TICK_TIME_DELTA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("TEXT_SCALE_NAME")] 
		public CFloat TEXT_SCALE_NAME
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("TEXT_SCALE_ATTITUDE")] 
		public CFloat TEXT_SCALE_ATTITUDE
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("TEXT_SCALE_IMMORTALITY_MODE")] 
		public CFloat TEXT_SCALE_IMMORTALITY_MODE
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("TEXT_TOP")] 
		public CFloat TEXT_TOP
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("TEXT_OFFSET")] 
		public CFloat TEXT_OFFSET
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DEBUG_VisualizerComponent()
		{
			Records = new();
			TICK_TIME_DELTA = 0.010000F;
			TEXT_SCALE_NAME = 3.000000F;
			TEXT_SCALE_ATTITUDE = 2.000000F;
			TEXT_SCALE_IMMORTALITY_MODE = 1.000000F;
			TEXT_TOP = 2.300000F;
			TEXT_OFFSET = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
