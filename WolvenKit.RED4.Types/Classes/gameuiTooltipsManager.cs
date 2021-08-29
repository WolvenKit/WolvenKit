using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTooltipsManager : inkWidgetLogicController
	{
		private inkWidgetReference _tooltipsContainer;
		private CBool _flipX;
		private CBool _flipY;
		private inkMargin _rootMargin;
		private inkMargin _screenMargin;
		private CArray<inkWidgetReference> _tooltipRequesters;
		private CArray<CName> _genericTooltipsNames;
		private CArray<TooltipWidgetReference> _tooltipLibrariesReferences;
		private CArray<TooltipWidgetStyledReference> _tooltipLibrariesStyledReferences;
		private redResourceReferenceScriptToken _tooltipsLibrary;
		private redResourceReferenceScriptToken _menuTooltipStylePath;
		private redResourceReferenceScriptToken _hudTooltipStylePath;
		private CArray<CWeakHandle<AGenericTooltipController>> _indexedTooltips;
		private CArray<CHandle<NamedTooltipController>> _namedTooltips;
		private CHandle<inkanimProxy> _introAnim;

		[Ordinal(1)] 
		[RED("tooltipsContainer")] 
		public inkWidgetReference TooltipsContainer
		{
			get => GetProperty(ref _tooltipsContainer);
			set => SetProperty(ref _tooltipsContainer, value);
		}

		[Ordinal(2)] 
		[RED("flipX")] 
		public CBool FlipX
		{
			get => GetProperty(ref _flipX);
			set => SetProperty(ref _flipX, value);
		}

		[Ordinal(3)] 
		[RED("flipY")] 
		public CBool FlipY
		{
			get => GetProperty(ref _flipY);
			set => SetProperty(ref _flipY, value);
		}

		[Ordinal(4)] 
		[RED("rootMargin")] 
		public inkMargin RootMargin
		{
			get => GetProperty(ref _rootMargin);
			set => SetProperty(ref _rootMargin, value);
		}

		[Ordinal(5)] 
		[RED("screenMargin")] 
		public inkMargin ScreenMargin
		{
			get => GetProperty(ref _screenMargin);
			set => SetProperty(ref _screenMargin, value);
		}

		[Ordinal(6)] 
		[RED("TooltipRequesters")] 
		public CArray<inkWidgetReference> TooltipRequesters
		{
			get => GetProperty(ref _tooltipRequesters);
			set => SetProperty(ref _tooltipRequesters, value);
		}

		[Ordinal(7)] 
		[RED("GenericTooltipsNames")] 
		public CArray<CName> GenericTooltipsNames
		{
			get => GetProperty(ref _genericTooltipsNames);
			set => SetProperty(ref _genericTooltipsNames, value);
		}

		[Ordinal(8)] 
		[RED("TooltipLibrariesReferences")] 
		public CArray<TooltipWidgetReference> TooltipLibrariesReferences
		{
			get => GetProperty(ref _tooltipLibrariesReferences);
			set => SetProperty(ref _tooltipLibrariesReferences, value);
		}

		[Ordinal(9)] 
		[RED("TooltipLibrariesStyledReferences")] 
		public CArray<TooltipWidgetStyledReference> TooltipLibrariesStyledReferences
		{
			get => GetProperty(ref _tooltipLibrariesStyledReferences);
			set => SetProperty(ref _tooltipLibrariesStyledReferences, value);
		}

		[Ordinal(10)] 
		[RED("TooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get => GetProperty(ref _tooltipsLibrary);
			set => SetProperty(ref _tooltipsLibrary, value);
		}

		[Ordinal(11)] 
		[RED("MenuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetProperty(ref _menuTooltipStylePath);
			set => SetProperty(ref _menuTooltipStylePath, value);
		}

		[Ordinal(12)] 
		[RED("HudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetProperty(ref _hudTooltipStylePath);
			set => SetProperty(ref _hudTooltipStylePath, value);
		}

		[Ordinal(13)] 
		[RED("IndexedTooltips")] 
		public CArray<CWeakHandle<AGenericTooltipController>> IndexedTooltips
		{
			get => GetProperty(ref _indexedTooltips);
			set => SetProperty(ref _indexedTooltips, value);
		}

		[Ordinal(14)] 
		[RED("NamedTooltips")] 
		public CArray<CHandle<NamedTooltipController>> NamedTooltips
		{
			get => GetProperty(ref _namedTooltips);
			set => SetProperty(ref _namedTooltips, value);
		}

		[Ordinal(15)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetProperty(ref _introAnim);
			set => SetProperty(ref _introAnim, value);
		}
	}
}
