using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWidgetPackageBase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("libraryPath")] 
		public redResourceReferenceScriptToken LibraryPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(1)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("widgetTweakDBID")] 
		public TweakDBID WidgetTweakDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("widgetName")] 
		public CString WidgetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("placement")] 
		public CEnum<EWidgetPlacementType> Placement
		{
			get => GetPropertyValue<CEnum<EWidgetPlacementType>>();
			set => SetPropertyValue<CEnum<EWidgetPlacementType>>(value);
		}

		[Ordinal(6)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetPropertyValue<CEnum<inkEOrientation>>();
			set => SetPropertyValue<CEnum<inkEOrientation>>(value);
		}

		[Ordinal(7)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SWidgetPackageBase()
		{
			LibraryPath = new();
			IsValid = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
