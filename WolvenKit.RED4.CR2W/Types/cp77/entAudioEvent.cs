using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAudioEvent : redEvent
	{
		private CName _eventName;
		private CName _emitterName;
		private CName _nameData;
		private CFloat _floatData;
		private CEnum<audioEventActionType> _eventType;
		private CEnum<audioAudioEventFlags> _eventFlags;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "emitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nameData")] 
		public CName NameData
		{
			get
			{
				if (_nameData == null)
				{
					_nameData = (CName) CR2WTypeManager.Create("CName", "nameData", cr2w, this);
				}
				return _nameData;
			}
			set
			{
				if (_nameData == value)
				{
					return;
				}
				_nameData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("floatData")] 
		public CFloat FloatData
		{
			get
			{
				if (_floatData == null)
				{
					_floatData = (CFloat) CR2WTypeManager.Create("Float", "floatData", cr2w, this);
				}
				return _floatData;
			}
			set
			{
				if (_floatData == value)
				{
					return;
				}
				_floatData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<audioEventActionType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<audioEventActionType>) CR2WTypeManager.Create("audioEventActionType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("eventFlags")] 
		public CEnum<audioAudioEventFlags> EventFlags
		{
			get
			{
				if (_eventFlags == null)
				{
					_eventFlags = (CEnum<audioAudioEventFlags>) CR2WTypeManager.Create("audioAudioEventFlags", "eventFlags", cr2w, this);
				}
				return _eventFlags;
			}
			set
			{
				if (_eventFlags == value)
				{
					return;
				}
				_eventFlags = value;
				PropertySet(this);
			}
		}

		public entAudioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
