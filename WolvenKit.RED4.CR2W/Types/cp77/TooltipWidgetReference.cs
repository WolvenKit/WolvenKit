using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipWidgetReference : CVariable
	{
		private CName _identifier;
		private inkWidgetLibraryReference _widgetLibraryReference;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CName) CR2WTypeManager.Create("CName", "identifier", cr2w, this);
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
		[RED("widgetLibraryReference")] 
		public inkWidgetLibraryReference WidgetLibraryReference
		{
			get
			{
				if (_widgetLibraryReference == null)
				{
					_widgetLibraryReference = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "widgetLibraryReference", cr2w, this);
				}
				return _widgetLibraryReference;
			}
			set
			{
				if (_widgetLibraryReference == value)
				{
					return;
				}
				_widgetLibraryReference = value;
				PropertySet(this);
			}
		}

		public TooltipWidgetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
