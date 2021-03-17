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
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryReference")] 
		public inkWidgetLibraryReference WidgetLibraryReference
		{
			get => GetProperty(ref _widgetLibraryReference);
			set => SetProperty(ref _widgetLibraryReference, value);
		}

		[Ordinal(2)] 
		[RED("menuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetProperty(ref _menuTooltipStylePath);
			set => SetProperty(ref _menuTooltipStylePath, value);
		}

		[Ordinal(3)] 
		[RED("hudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetProperty(ref _hudTooltipStylePath);
			set => SetProperty(ref _hudTooltipStylePath, value);
		}

		public TooltipWidgetStyledReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
