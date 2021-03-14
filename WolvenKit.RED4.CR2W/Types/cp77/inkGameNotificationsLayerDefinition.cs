using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameNotificationsLayerDefinition : inkLayerDefinition
	{
		private rRef<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
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

		public inkGameNotificationsLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
