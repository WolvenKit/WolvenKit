using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNodeVisibilityMapArrayElement : CVariable
	{
		private worldGlobalNodeRef _globalNodeRef;
		private CBool _visible;

		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get
			{
				if (_globalNodeRef == null)
				{
					_globalNodeRef = (worldGlobalNodeRef) CR2WTypeManager.Create("worldGlobalNodeRef", "globalNodeRef", cr2w, this);
				}
				return _globalNodeRef;
			}
			set
			{
				if (_globalNodeRef == value)
				{
					return;
				}
				_globalNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		public questNodeVisibilityMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
