using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UploadProgramProgressEvent : redEvent
	{
		private CEnum<EUploadProgramState> _state;
		private CEnum<EProgressBarType> _progressBarType;
		private CEnum<EProgressBarContext> _progressBarContext;
		private CFloat _duration;
		private wCHandle<gamedataChoiceCaptionIconPart_Record> _iconRecord;
		private CHandle<ScriptableDeviceAction> _action;
		private CName _slotName;
		private CEnum<gamedataStatPoolType> _statPoolType;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<EUploadProgramState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EUploadProgramState>) CR2WTypeManager.Create("EUploadProgramState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get
			{
				if (_progressBarType == null)
				{
					_progressBarType = (CEnum<EProgressBarType>) CR2WTypeManager.Create("EProgressBarType", "progressBarType", cr2w, this);
				}
				return _progressBarType;
			}
			set
			{
				if (_progressBarType == value)
				{
					return;
				}
				_progressBarType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get
			{
				if (_progressBarContext == null)
				{
					_progressBarContext = (CEnum<EProgressBarContext>) CR2WTypeManager.Create("EProgressBarContext", "progressBarContext", cr2w, this);
				}
				return _progressBarContext;
			}
			set
			{
				if (_progressBarContext == value)
				{
					return;
				}
				_progressBarContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconRecord")] 
		public wCHandle<gamedataChoiceCaptionIconPart_Record> IconRecord
		{
			get
			{
				if (_iconRecord == null)
				{
					_iconRecord = (wCHandle<gamedataChoiceCaptionIconPart_Record>) CR2WTypeManager.Create("whandle:gamedataChoiceCaptionIconPart_Record", "iconRecord", cr2w, this);
				}
				return _iconRecord;
			}
			set
			{
				if (_iconRecord == value)
				{
					return;
				}
				_iconRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		public UploadProgramProgressEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
