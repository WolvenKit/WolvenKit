using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TalkingTriggerRequest : gameScriptableSystemRequest
	{
		private CBool _isPlayerCalling;
		private CName _contact;
		private CEnum<questPhoneTalkingState> _state;

		[Ordinal(0)] 
		[RED("isPlayerCalling")] 
		public CBool IsPlayerCalling
		{
			get
			{
				if (_isPlayerCalling == null)
				{
					_isPlayerCalling = (CBool) CR2WTypeManager.Create("Bool", "isPlayerCalling", cr2w, this);
				}
				return _isPlayerCalling;
			}
			set
			{
				if (_isPlayerCalling == value)
				{
					return;
				}
				_isPlayerCalling = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("contact")] 
		public CName Contact
		{
			get
			{
				if (_contact == null)
				{
					_contact = (CName) CR2WTypeManager.Create("CName", "contact", cr2w, this);
				}
				return _contact;
			}
			set
			{
				if (_contact == value)
				{
					return;
				}
				_contact = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<questPhoneTalkingState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<questPhoneTalkingState>) CR2WTypeManager.Create("questPhoneTalkingState", "state", cr2w, this);
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

		public TalkingTriggerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
