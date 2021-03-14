using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsVoicePlayedEvent : redEvent
	{
		private CName _eventName;
		private CEnum<audioVoGruntType> _gruntType;
		private CBool _isV;

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
		[RED("gruntType")] 
		public CEnum<audioVoGruntType> GruntType
		{
			get
			{
				if (_gruntType == null)
				{
					_gruntType = (CEnum<audioVoGruntType>) CR2WTypeManager.Create("audioVoGruntType", "gruntType", cr2w, this);
				}
				return _gruntType;
			}
			set
			{
				if (_gruntType == value)
				{
					return;
				}
				_gruntType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isV")] 
		public CBool IsV
		{
			get
			{
				if (_isV == null)
				{
					_isV = (CBool) CR2WTypeManager.Create("Bool", "isV", cr2w, this);
				}
				return _isV;
			}
			set
			{
				if (_isV == value)
				{
					return;
				}
				_isV = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsVoicePlayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
