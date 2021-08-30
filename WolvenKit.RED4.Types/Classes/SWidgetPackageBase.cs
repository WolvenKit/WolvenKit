using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SWidgetPackageBase : RedBaseClass
	{
		private redResourceReferenceScriptToken _libraryPath;
		private CName _libraryID;
		private TweakDBID _widgetTweakDBID;
		private CWeakHandle<inkWidget> _widget;
		private CString _widgetName;
		private CEnum<EWidgetPlacementType> _placement;
		private CBool _isValid;

		[Ordinal(0)] 
		[RED("libraryPath")] 
		public redResourceReferenceScriptToken LibraryPath
		{
			get => GetProperty(ref _libraryPath);
			set => SetProperty(ref _libraryPath, value);
		}

		[Ordinal(1)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetProperty(ref _libraryID);
			set => SetProperty(ref _libraryID, value);
		}

		[Ordinal(2)] 
		[RED("widgetTweakDBID")] 
		public TweakDBID WidgetTweakDBID
		{
			get => GetProperty(ref _widgetTweakDBID);
			set => SetProperty(ref _widgetTweakDBID, value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(4)] 
		[RED("widgetName")] 
		public CString WidgetName
		{
			get => GetProperty(ref _widgetName);
			set => SetProperty(ref _widgetName, value);
		}

		[Ordinal(5)] 
		[RED("placement")] 
		public CEnum<EWidgetPlacementType> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		[Ordinal(6)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		public SWidgetPackageBase()
		{
			_isValid = true;
		}
	}
}
