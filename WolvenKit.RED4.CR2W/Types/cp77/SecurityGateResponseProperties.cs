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
			get => GetProperty(ref _securityGateResponseType);
			set => SetProperty(ref _securityGateResponseType, value);
		}

		[Ordinal(1)] 
		[RED("securityLevelAccessGranted")] 
		public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted
		{
			get => GetProperty(ref _securityLevelAccessGranted);
			set => SetProperty(ref _securityLevelAccessGranted, value);
		}

		public SecurityGateResponseProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
