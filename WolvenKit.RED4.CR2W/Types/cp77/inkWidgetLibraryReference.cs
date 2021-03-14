using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryReference : CVariable
	{
		private inkWidgetLibraryResourceWrapper _widgetLibrary;
		private CName _widgetItem;

		[Ordinal(0)] 
		[RED("widgetLibrary")] 
		public inkWidgetLibraryResourceWrapper WidgetLibrary
		{
			get
			{
				if (_widgetLibrary == null)
				{
					_widgetLibrary = (inkWidgetLibraryResourceWrapper) CR2WTypeManager.Create("inkWidgetLibraryResourceWrapper", "widgetLibrary", cr2w, this);
				}
				return _widgetLibrary;
			}
			set
			{
				if (_widgetLibrary == value)
				{
					return;
				}
				_widgetLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetItem")] 
		public CName WidgetItem
		{
			get
			{
				if (_widgetItem == null)
				{
					_widgetItem = (CName) CR2WTypeManager.Create("CName", "widgetItem", cr2w, this);
				}
				return _widgetItem;
			}
			set
			{
				if (_widgetItem == value)
				{
					return;
				}
				_widgetItem = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
