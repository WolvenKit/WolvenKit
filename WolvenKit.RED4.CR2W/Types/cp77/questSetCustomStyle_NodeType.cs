using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetCustomStyle_NodeType : questIPhoneManagerNodeType
	{
		private CEnum<questCustomStyle> _style;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("style")] 
		public CEnum<questCustomStyle> Style
		{
			get
			{
				if (_style == null)
				{
					_style = (CEnum<questCustomStyle>) CR2WTypeManager.Create("questCustomStyle", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public questSetCustomStyle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
