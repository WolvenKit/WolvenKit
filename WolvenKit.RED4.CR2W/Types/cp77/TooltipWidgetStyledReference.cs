using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipWidgetStyledReference : CVariable
	{
		private CName _identifier;
		private inkWidgetLibraryReference _widgetLibraryReference;
		private redResourceReferenceScriptToken _menuTooltipStylePath;
		private redResourceReferenceScriptToken _hudTooltipStylePath;

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

		[Ordinal(2)] 
		[RED("menuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get
			{
				if (_menuTooltipStylePath == null)
				{
					_menuTooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "menuTooltipStylePath", cr2w, this);
				}
				return _menuTooltipStylePath;
			}
			set
			{
				if (_menuTooltipStylePath == value)
				{
					return;
				}
				_menuTooltipStylePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get
			{
				if (_hudTooltipStylePath == null)
				{
					_hudTooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "hudTooltipStylePath", cr2w, this);
				}
				return _hudTooltipStylePath;
			}
			set
			{
				if (_hudTooltipStylePath == value)
				{
					return;
				}
				_hudTooltipStylePath = value;
				PropertySet(this);
			}
		}

		public TooltipWidgetStyledReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
