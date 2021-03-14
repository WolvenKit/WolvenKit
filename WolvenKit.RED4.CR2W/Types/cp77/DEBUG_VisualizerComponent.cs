using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualizerComponent : gameScriptableComponent
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
			get
			{
				if (_records == null)
				{
					_records = (CArray<DEBUG_VisualRecord>) CR2WTypeManager.Create("array:DEBUG_VisualRecord", "records", cr2w, this);
				}
				return _records;
			}
			set
			{
				if (_records == value)
				{
					return;
				}
				_records = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offsetCounter")] 
		public CInt32 OffsetCounter
		{
			get
			{
				if (_offsetCounter == null)
				{
					_offsetCounter = (CInt32) CR2WTypeManager.Create("Int32", "offsetCounter", cr2w, this);
				}
				return _offsetCounter;
			}
			set
			{
				if (_offsetCounter == value)
				{
					return;
				}
				_offsetCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get
			{
				if (_timeToNextUpdate == null)
				{
					_timeToNextUpdate = (CFloat) CR2WTypeManager.Create("Float", "timeToNextUpdate", cr2w, this);
				}
				return _timeToNextUpdate;
			}
			set
			{
				if (_timeToNextUpdate == value)
				{
					return;
				}
				_timeToNextUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("processedRecordIndex")] 
		public CInt32 ProcessedRecordIndex
		{
			get
			{
				if (_processedRecordIndex == null)
				{
					_processedRecordIndex = (CInt32) CR2WTypeManager.Create("Int32", "processedRecordIndex", cr2w, this);
				}
				return _processedRecordIndex;
			}
			set
			{
				if (_processedRecordIndex == value)
				{
					return;
				}
				_processedRecordIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("showWeaponsStreaming")] 
		public CBool ShowWeaponsStreaming
		{
			get
			{
				if (_showWeaponsStreaming == null)
				{
					_showWeaponsStreaming = (CBool) CR2WTypeManager.Create("Bool", "showWeaponsStreaming", cr2w, this);
				}
				return _showWeaponsStreaming;
			}
			set
			{
				if (_showWeaponsStreaming == value)
				{
					return;
				}
				_showWeaponsStreaming = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("TICK_TIME_DELTA")] 
		public CFloat TICK_TIME_DELTA
		{
			get
			{
				if (_tICK_TIME_DELTA == null)
				{
					_tICK_TIME_DELTA = (CFloat) CR2WTypeManager.Create("Float", "TICK_TIME_DELTA", cr2w, this);
				}
				return _tICK_TIME_DELTA;
			}
			set
			{
				if (_tICK_TIME_DELTA == value)
				{
					return;
				}
				_tICK_TIME_DELTA = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("TEXT_SCALE_NAME")] 
		public CFloat TEXT_SCALE_NAME
		{
			get
			{
				if (_tEXT_SCALE_NAME == null)
				{
					_tEXT_SCALE_NAME = (CFloat) CR2WTypeManager.Create("Float", "TEXT_SCALE_NAME", cr2w, this);
				}
				return _tEXT_SCALE_NAME;
			}
			set
			{
				if (_tEXT_SCALE_NAME == value)
				{
					return;
				}
				_tEXT_SCALE_NAME = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("TEXT_SCALE_ATTITUDE")] 
		public CFloat TEXT_SCALE_ATTITUDE
		{
			get
			{
				if (_tEXT_SCALE_ATTITUDE == null)
				{
					_tEXT_SCALE_ATTITUDE = (CFloat) CR2WTypeManager.Create("Float", "TEXT_SCALE_ATTITUDE", cr2w, this);
				}
				return _tEXT_SCALE_ATTITUDE;
			}
			set
			{
				if (_tEXT_SCALE_ATTITUDE == value)
				{
					return;
				}
				_tEXT_SCALE_ATTITUDE = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TEXT_SCALE_IMMORTALITY_MODE")] 
		public CFloat TEXT_SCALE_IMMORTALITY_MODE
		{
			get
			{
				if (_tEXT_SCALE_IMMORTALITY_MODE == null)
				{
					_tEXT_SCALE_IMMORTALITY_MODE = (CFloat) CR2WTypeManager.Create("Float", "TEXT_SCALE_IMMORTALITY_MODE", cr2w, this);
				}
				return _tEXT_SCALE_IMMORTALITY_MODE;
			}
			set
			{
				if (_tEXT_SCALE_IMMORTALITY_MODE == value)
				{
					return;
				}
				_tEXT_SCALE_IMMORTALITY_MODE = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("TEXT_TOP")] 
		public CFloat TEXT_TOP
		{
			get
			{
				if (_tEXT_TOP == null)
				{
					_tEXT_TOP = (CFloat) CR2WTypeManager.Create("Float", "TEXT_TOP", cr2w, this);
				}
				return _tEXT_TOP;
			}
			set
			{
				if (_tEXT_TOP == value)
				{
					return;
				}
				_tEXT_TOP = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("TEXT_OFFSET")] 
		public CFloat TEXT_OFFSET
		{
			get
			{
				if (_tEXT_OFFSET == null)
				{
					_tEXT_OFFSET = (CFloat) CR2WTypeManager.Create("Float", "TEXT_OFFSET", cr2w, this);
				}
				return _tEXT_OFFSET;
			}
			set
			{
				if (_tEXT_OFFSET == value)
				{
					return;
				}
				_tEXT_OFFSET = value;
				PropertySet(this);
			}
		}

		public DEBUG_VisualizerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
