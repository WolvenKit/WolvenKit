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

		[Ordinal(104)] 
		[RED("securityGateDetectionProperties")] 
		public SecurityGateDetectionProperties SecurityGateDetectionProperties
		{
			get
			{
				if (_securityGateDetectionProperties == null)
				{
					_securityGateDetectionProperties = (SecurityGateDetectionProperties) CR2WTypeManager.Create("SecurityGateDetectionProperties", "securityGateDetectionProperties", cr2w, this);
				}
				return _securityGateDetectionProperties;
			}
			set
			{
				if (_securityGateDetectionProperties == value)
				{
					return;
				}
				_securityGateDetectionProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("securityGateResponseProperties")] 
		public SecurityGateResponseProperties SecurityGateResponseProperties
		{
			get
			{
				if (_securityGateResponseProperties == null)
				{
					_securityGateResponseProperties = (SecurityGateResponseProperties) CR2WTypeManager.Create("SecurityGateResponseProperties", "securityGateResponseProperties", cr2w, this);
				}
				return _securityGateResponseProperties;
			}
			set
			{
				if (_securityGateResponseProperties == value)
				{
					return;
				}
				_securityGateResponseProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("securityGateStatus")] 
		public CEnum<ESecurityGateStatus> SecurityGateStatus
		{
			get
			{
				if (_securityGateStatus == null)
				{
					_securityGateStatus = (CEnum<ESecurityGateStatus>) CR2WTypeManager.Create("ESecurityGateStatus", "securityGateStatus", cr2w, this);
				}
				return _securityGateStatus;
			}
			set
			{
				if (_securityGateStatus == value)
				{
					return;
				}
				_securityGateStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get
			{
				if (_trespassersDataList == null)
				{
					_trespassersDataList = (CArray<TrespasserEntry>) CR2WTypeManager.Create("array:TrespasserEntry", "trespassersDataList", cr2w, this);
				}
				return _trespassersDataList;
			}
			set
			{
				if (_trespassersDataList == value)
				{
					return;
				}
				_trespassersDataList = value;
				PropertySet(this);
			}
		}

		public SecurityGateControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
