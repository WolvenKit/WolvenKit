using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberspaceUIObject : gameObject
	{
		private CName _slotName;
		private CEnum<gameuiCyberspaceElementType> _mappinType;
		private CString _caption;

		[Ordinal(40)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("mappinType")] 
		public CEnum<gameuiCyberspaceElementType> MappinType
		{
			get
			{
				if (_mappinType == null)
				{
					_mappinType = (CEnum<gameuiCyberspaceElementType>) CR2WTypeManager.Create("gameuiCyberspaceElementType", "mappinType", cr2w, this);
				}
				return _mappinType;
			}
			set
			{
				if (_mappinType == value)
				{
					return;
				}
				_mappinType = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("caption")] 
		public CString Caption
		{
			get
			{
				if (_caption == null)
				{
					_caption = (CString) CR2WTypeManager.Create("String", "caption", cr2w, this);
				}
				return _caption;
			}
			set
			{
				if (_caption == value)
				{
					return;
				}
				_caption = value;
				PropertySet(this);
			}
		}

		public gameuiCyberspaceUIObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
