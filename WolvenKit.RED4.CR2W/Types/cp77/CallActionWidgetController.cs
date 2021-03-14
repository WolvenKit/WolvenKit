using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _statusText;
		private CName _callingAnimName;
		private CName _talkingAnimName;
		private CEnum<IntercomStatus> _status;

		[Ordinal(28)] 
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get
			{
				if (_statusText == null)
				{
					_statusText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statusText", cr2w, this);
				}
				return _statusText;
			}
			set
			{
				if (_statusText == value)
				{
					return;
				}
				_statusText = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("callingAnimName")] 
		public CName CallingAnimName
		{
			get
			{
				if (_callingAnimName == null)
				{
					_callingAnimName = (CName) CR2WTypeManager.Create("CName", "callingAnimName", cr2w, this);
				}
				return _callingAnimName;
			}
			set
			{
				if (_callingAnimName == value)
				{
					return;
				}
				_callingAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("talkingAnimName")] 
		public CName TalkingAnimName
		{
			get
			{
				if (_talkingAnimName == null)
				{
					_talkingAnimName = (CName) CR2WTypeManager.Create("CName", "talkingAnimName", cr2w, this);
				}
				return _talkingAnimName;
			}
			set
			{
				if (_talkingAnimName == value)
				{
					return;
				}
				_talkingAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("status")] 
		public CEnum<IntercomStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<IntercomStatus>) CR2WTypeManager.Create("IntercomStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		public CallActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
