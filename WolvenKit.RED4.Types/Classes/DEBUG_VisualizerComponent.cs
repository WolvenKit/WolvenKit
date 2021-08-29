using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DEBUG_VisualizerComponent : gameScriptableComponent
	{
		private CArray<DEBUG_VisualRecord> _records;
		private CInt32 _offsetCounter;
		private CFloat _timeToNextUpdate;
		private CInt32 _processedRecordIndex;
		private CBool _showWeaponsStreaming;
		private CFloat _tICK_TIME_DELTA;
		private CFloat _tEXT_SCALE_NAME;
		private CFloat _tEXT_SCALE_ATTITUDE;
		private CFloat _tEXT_SCALE_IMMORTALITY_MODE;
		private CFloat _tEXT_TOP;
		private CFloat _tEXT_OFFSET;

		[Ordinal(5)] 
		[RED("records")] 
		public CArray<DEBUG_VisualRecord> Records
		{
			get => GetProperty(ref _records);
			set => SetProperty(ref _records, value);
		}

		[Ordinal(6)] 
		[RED("offsetCounter")] 
		public CInt32 OffsetCounter
		{
			get => GetProperty(ref _offsetCounter);
			set => SetProperty(ref _offsetCounter, value);
		}

		[Ordinal(7)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetProperty(ref _timeToNextUpdate);
			set => SetProperty(ref _timeToNextUpdate, value);
		}

		[Ordinal(8)] 
		[RED("processedRecordIndex")] 
		public CInt32 ProcessedRecordIndex
		{
			get => GetProperty(ref _processedRecordIndex);
			set => SetProperty(ref _processedRecordIndex, value);
		}

		[Ordinal(9)] 
		[RED("showWeaponsStreaming")] 
		public CBool ShowWeaponsStreaming
		{
			get => GetProperty(ref _showWeaponsStreaming);
			set => SetProperty(ref _showWeaponsStreaming, value);
		}

		[Ordinal(10)] 
		[RED("TICK_TIME_DELTA")] 
		public CFloat TICK_TIME_DELTA
		{
			get => GetProperty(ref _tICK_TIME_DELTA);
			set => SetProperty(ref _tICK_TIME_DELTA, value);
		}

		[Ordinal(11)] 
		[RED("TEXT_SCALE_NAME")] 
		public CFloat TEXT_SCALE_NAME
		{
			get => GetProperty(ref _tEXT_SCALE_NAME);
			set => SetProperty(ref _tEXT_SCALE_NAME, value);
		}

		[Ordinal(12)] 
		[RED("TEXT_SCALE_ATTITUDE")] 
		public CFloat TEXT_SCALE_ATTITUDE
		{
			get => GetProperty(ref _tEXT_SCALE_ATTITUDE);
			set => SetProperty(ref _tEXT_SCALE_ATTITUDE, value);
		}

		[Ordinal(13)] 
		[RED("TEXT_SCALE_IMMORTALITY_MODE")] 
		public CFloat TEXT_SCALE_IMMORTALITY_MODE
		{
			get => GetProperty(ref _tEXT_SCALE_IMMORTALITY_MODE);
			set => SetProperty(ref _tEXT_SCALE_IMMORTALITY_MODE, value);
		}

		[Ordinal(14)] 
		[RED("TEXT_TOP")] 
		public CFloat TEXT_TOP
		{
			get => GetProperty(ref _tEXT_TOP);
			set => SetProperty(ref _tEXT_TOP, value);
		}

		[Ordinal(15)] 
		[RED("TEXT_OFFSET")] 
		public CFloat TEXT_OFFSET
		{
			get => GetProperty(ref _tEXT_OFFSET);
			set => SetProperty(ref _tEXT_OFFSET, value);
		}
	}
}
