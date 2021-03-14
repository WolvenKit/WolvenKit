using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMenuLayerDefinition : inkLayerDefinition
	{
		private rRef<inkMenuResource> _menuResource;
		private rRef<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("menuResource")] 
		public rRef<inkMenuResource> MenuResource
		{
			get
			{
				if (_menuResource == null)
				{
					_menuResource = (rRef<inkMenuResource>) CR2WTypeManager.Create("rRef:inkMenuResource", "menuResource", cr2w, this);
				}
				return _menuResource;
			}
			set
			{
				if (_menuResource == value)
				{
					return;
				}
				_menuResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get
			{
				if (_cursorResource == null)
				{
					_cursorResource = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "cursorResource", cr2w, this);
				}
				return _cursorResource;
			}
			set
			{
				if (_cursorResource == value)
				{
					return;
				}
				_cursorResource = value;
				PropertySet(this);
			}
		}

		public inkMenuLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
