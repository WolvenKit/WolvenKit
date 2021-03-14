using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInspect_ConditionType : questIObjectConditionType
	{
		private CString _objectID;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get
			{
				if (_objectID == null)
				{
					_objectID = (CString) CR2WTypeManager.Create("String", "objectID", cr2w, this);
				}
				return _objectID;
			}
			set
			{
				if (_objectID == value)
				{
					return;
				}
				_objectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		public questInspect_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
