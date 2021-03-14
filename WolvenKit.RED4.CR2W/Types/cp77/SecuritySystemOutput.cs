using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutput : ActionBool
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CHandle<SecuritySystemInput> _originalInputEvent;
		private CBool _securityStateChanged;

		[Ordinal(25)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get
			{
				if (_currentSecurityState == null)
				{
					_currentSecurityState = (CEnum<ESecuritySystemState>) CR2WTypeManager.Create("ESecuritySystemState", "currentSecurityState", cr2w, this);
				}
				return _currentSecurityState;
			}
			set
			{
				if (_currentSecurityState == value)
				{
					return;
				}
				_currentSecurityState = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get
			{
				if (_breachOrigin == null)
				{
					_breachOrigin = (CEnum<EBreachOrigin>) CR2WTypeManager.Create("EBreachOrigin", "breachOrigin", cr2w, this);
				}
				return _breachOrigin;
			}
			set
			{
				if (_breachOrigin == value)
				{
					return;
				}
				_breachOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("originalInputEvent")] 
		public CHandle<SecuritySystemInput> OriginalInputEvent
		{
			get
			{
				if (_originalInputEvent == null)
				{
					_originalInputEvent = (CHandle<SecuritySystemInput>) CR2WTypeManager.Create("handle:SecuritySystemInput", "originalInputEvent", cr2w, this);
				}
				return _originalInputEvent;
			}
			set
			{
				if (_originalInputEvent == value)
				{
					return;
				}
				_originalInputEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get
			{
				if (_securityStateChanged == null)
				{
					_securityStateChanged = (CBool) CR2WTypeManager.Create("Bool", "securityStateChanged", cr2w, this);
				}
				return _securityStateChanged;
			}
			set
			{
				if (_securityStateChanged == value)
				{
					return;
				}
				_securityStateChanged = value;
				PropertySet(this);
			}
		}

		public SecuritySystemOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
