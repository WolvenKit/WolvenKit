using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneStatus_NodeType : questIPhoneManagerNodeType
	{
		private CEnum<questPhoneStatus> _status;
		private CName _customStatus;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<questPhoneStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<questPhoneStatus>) CR2WTypeManager.Create("questPhoneStatus", "status", cr2w, this);
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

		[Ordinal(1)] 
		[RED("customStatus")] 
		public CName CustomStatus
		{
			get
			{
				if (_customStatus == null)
				{
					_customStatus = (CName) CR2WTypeManager.Create("CName", "customStatus", cr2w, this);
				}
				return _customStatus;
			}
			set
			{
				if (_customStatus == value)
				{
					return;
				}
				_customStatus = value;
				PropertySet(this);
			}
		}

		public questSetPhoneStatus_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
