using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropdownItemData : IScriptable
	{
		private CVariant _identifier;
		private CName _labelKey;
		private CEnum<DropdownItemDirection> _direction;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CVariant) CR2WTypeManager.Create("Variant", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("labelKey")] 
		public CName LabelKey
		{
			get
			{
				if (_labelKey == null)
				{
					_labelKey = (CName) CR2WTypeManager.Create("CName", "labelKey", cr2w, this);
				}
				return _labelKey;
			}
			set
			{
				if (_labelKey == value)
				{
					return;
				}
				_labelKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<DropdownItemDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<DropdownItemDirection>) CR2WTypeManager.Create("DropdownItemDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public DropdownItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
