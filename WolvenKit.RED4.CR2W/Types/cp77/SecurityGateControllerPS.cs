using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateControllerPS : MasterControllerPS
	{
		private SecurityGateDetectionProperties _securityGateDetectionProperties;
		private SecurityGateResponseProperties _securityGateResponseProperties;
		private CEnum<ESecurityGateStatus> _securityGateStatus;
		private CArray<TrespasserEntry> _trespassersDataList;

		[Ordinal(105)] 
		[RED("securityGateDetectionProperties")] 
		public SecurityGateDetectionProperties SecurityGateDetectionProperties
		{
			get => GetProperty(ref _securityGateDetectionProperties);
			set => SetProperty(ref _securityGateDetectionProperties, value);
		}

		[Ordinal(106)] 
		[RED("securityGateResponseProperties")] 
		public SecurityGateResponseProperties SecurityGateResponseProperties
		{
			get => GetProperty(ref _securityGateResponseProperties);
			set => SetProperty(ref _securityGateResponseProperties, value);
		}

		[Ordinal(107)] 
		[RED("securityGateStatus")] 
		public CEnum<ESecurityGateStatus> SecurityGateStatus
		{
			get => GetProperty(ref _securityGateStatus);
			set => SetProperty(ref _securityGateStatus, value);
		}

		[Ordinal(108)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetProperty(ref _trespassersDataList);
			set => SetProperty(ref _trespassersDataList, value);
		}

		public SecurityGateControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
