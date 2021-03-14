using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardSerializableID : CVariable
	{
		private CName _blackboardName;
		private CName _fieldName;

		[Ordinal(0)] 
		[RED("blackboardName")] 
		public CName BlackboardName
		{
			get
			{
				if (_blackboardName == null)
				{
					_blackboardName = (CName) CR2WTypeManager.Create("CName", "blackboardName", cr2w, this);
				}
				return _blackboardName;
			}
			set
			{
				if (_blackboardName == value)
				{
					return;
				}
				_blackboardName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fieldName")] 
		public CName FieldName
		{
			get
			{
				if (_fieldName == null)
				{
					_fieldName = (CName) CR2WTypeManager.Create("CName", "fieldName", cr2w, this);
				}
				return _fieldName;
			}
			set
			{
				if (_fieldName == value)
				{
					return;
				}
				_fieldName = value;
				PropertySet(this);
			}
		}

		public gameBlackboardSerializableID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
