using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateResponseProperties : CVariable
	{
		private CEnum<ESecurityGateResponseType> _securityGateResponseType;
		private CEnum<ESecurityAccessLevel> _securityLevelAccessGranted;

		[Ordinal(0)] 
		[RED("securityGateResponseType")] 
		public CEnum<ESecurityGateResponseType> SecurityGateResponseType
		{
			get
			{
				if (_securityGateResponseType == null)
				{
					_securityGateResponseType = (CEnum<ESecurityGateResponseType>) CR2WTypeManager.Create("ESecurityGateResponseType", "securityGateResponseType", cr2w, this);
				}
				return _securityGateResponseType;
			}
			set
			{
				if (_securityGateResponseType == value)
				{
					return;
				}
				_securityGateResponseType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get
			{
				if (_securityLevelAccessGranted == null)
				{
					_securityLevelAccessGranted = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "securityLevelAccessGranted", cr2w, this);
				}
				return _securityLevelAccessGranted;
			}
			set
			{
				if (_securityLevelAccessGranted == value)
				{
					return;
				}
				_securityLevelAccessGranted = value;
				PropertySet(this);
			}
		}

		public SecurityGateResponseProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
