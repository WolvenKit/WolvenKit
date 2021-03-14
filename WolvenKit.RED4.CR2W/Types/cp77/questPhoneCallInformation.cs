using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallInformation : CVariable
	{
		private CEnum<questPhoneCallMode> _callMode;
		private CBool _isAudioCall;
		private CName _contactName;
		private CBool _isPlayerCalling;
		private CEnum<questPhoneCallPhase> _callPhase;

		[Ordinal(0)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get
			{
				if (_callMode == null)
				{
					_callMode = (CEnum<questPhoneCallMode>) CR2WTypeManager.Create("questPhoneCallMode", "callMode", cr2w, this);
				}
				return _callMode;
			}
			set
			{
				if (_callMode == value)
				{
					return;
				}
				_callMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isAudioCall")] 
		public CBool IsAudioCall
		{
			get
			{
				if (_isAudioCall == null)
				{
					_isAudioCall = (CBool) CR2WTypeManager.Create("Bool", "isAudioCall", cr2w, this);
				}
				return _isAudioCall;
			}
			set
			{
				if (_isAudioCall == value)
				{
					return;
				}
				_isAudioCall = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("contactName")] 
		public CName ContactName
		{
			get
			{
				if (_contactName == null)
				{
					_contactName = (CName) CR2WTypeManager.Create("CName", "contactName", cr2w, this);
				}
				return _contactName;
			}
			set
			{
				if (_contactName == value)
				{
					return;
				}
				_contactName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get
			{
				if (_callPhase == null)
				{
					_callPhase = (CEnum<questPhoneCallPhase>) CR2WTypeManager.Create("questPhoneCallPhase", "callPhase", cr2w, this);
				}
				return _callPhase;
			}
			set
			{
				if (_callPhase == value)
				{
					return;
				}
				_callPhase = value;
				PropertySet(this);
			}
		}

		public questPhoneCallInformation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
