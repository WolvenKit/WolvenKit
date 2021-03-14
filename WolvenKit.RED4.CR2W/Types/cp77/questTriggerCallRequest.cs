using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTriggerCallRequest : gameScriptableSystemRequest
	{
		private CName _caller;
		private CName _addressee;
		private CEnum<questPhoneCallPhase> _callPhase;
		private CEnum<questPhoneCallMode> _callMode;

		[Ordinal(0)] 
		[RED("caller")] 
		public CName Caller
		{
			get
			{
				if (_caller == null)
				{
					_caller = (CName) CR2WTypeManager.Create("CName", "caller", cr2w, this);
				}
				return _caller;
			}
			set
			{
				if (_caller == value)
				{
					return;
				}
				_caller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CName Addressee
		{
			get
			{
				if (_addressee == null)
				{
					_addressee = (CName) CR2WTypeManager.Create("CName", "addressee", cr2w, this);
				}
				return _addressee;
			}
			set
			{
				if (_addressee == value)
				{
					return;
				}
				_addressee = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public questTriggerCallRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
