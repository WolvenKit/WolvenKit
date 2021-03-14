using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaData : CVariable
	{
		private wCHandle<SecurityAreaControllerPS> _securityArea;
		private CEnum<ESecurityAreaType> _securityAreaType;
		private CEnum<ESecurityAccessLevel> _accessLevel;
		private CString _zoneName;
		private CBool _entered;
		private gamePersistentID _id;
		private CEnum<EFilterType> _incomingFilters;
		private CEnum<EFilterType> _outgoingFilters;

		[Ordinal(0)] 
		[RED("securityArea")] 
		public wCHandle<SecurityAreaControllerPS> SecurityArea
		{
			get
			{
				if (_securityArea == null)
				{
					_securityArea = (wCHandle<SecurityAreaControllerPS>) CR2WTypeManager.Create("whandle:SecurityAreaControllerPS", "securityArea", cr2w, this);
				}
				return _securityArea;
			}
			set
			{
				if (_securityArea == value)
				{
					return;
				}
				_securityArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get
			{
				if (_securityAreaType == null)
				{
					_securityAreaType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "securityAreaType", cr2w, this);
				}
				return _securityAreaType;
			}
			set
			{
				if (_securityAreaType == value)
				{
					return;
				}
				_securityAreaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("accessLevel")] 
		public CEnum<ESecurityAccessLevel> AccessLevel
		{
			get
			{
				if (_accessLevel == null)
				{
					_accessLevel = (CEnum<ESecurityAccessLevel>) CR2WTypeManager.Create("ESecurityAccessLevel", "accessLevel", cr2w, this);
				}
				return _accessLevel;
			}
			set
			{
				if (_accessLevel == value)
				{
					return;
				}
				_accessLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("zoneName")] 
		public CString ZoneName
		{
			get
			{
				if (_zoneName == null)
				{
					_zoneName = (CString) CR2WTypeManager.Create("String", "zoneName", cr2w, this);
				}
				return _zoneName;
			}
			set
			{
				if (_zoneName == value)
				{
					return;
				}
				_zoneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entered")] 
		public CBool Entered
		{
			get
			{
				if (_entered == null)
				{
					_entered = (CBool) CR2WTypeManager.Create("Bool", "entered", cr2w, this);
				}
				return _entered;
			}
			set
			{
				if (_entered == value)
				{
					return;
				}
				_entered = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("id")] 
		public gamePersistentID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("incomingFilters")] 
		public CEnum<EFilterType> IncomingFilters
		{
			get
			{
				if (_incomingFilters == null)
				{
					_incomingFilters = (CEnum<EFilterType>) CR2WTypeManager.Create("EFilterType", "incomingFilters", cr2w, this);
				}
				return _incomingFilters;
			}
			set
			{
				if (_incomingFilters == value)
				{
					return;
				}
				_incomingFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("outgoingFilters")] 
		public CEnum<EFilterType> OutgoingFilters
		{
			get
			{
				if (_outgoingFilters == null)
				{
					_outgoingFilters = (CEnum<EFilterType>) CR2WTypeManager.Create("EFilterType", "outgoingFilters", cr2w, this);
				}
				return _outgoingFilters;
			}
			set
			{
				if (_outgoingFilters == value)
				{
					return;
				}
				_outgoingFilters = value;
				PropertySet(this);
			}
		}

		public SecurityAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
