using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkSelectorController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<CString> Values
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(3)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("SelectionChanged")] 
		public inkSelectionChangeCallback SelectionChanged
		{
			get => GetPropertyValue<inkSelectionChangeCallback>();
			set => SetPropertyValue<inkSelectionChangeCallback>(value);
		}

		[Ordinal(5)] 
		[RED("labelPath")] 
		public CName LabelPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("valuePath")] 
		public CName ValuePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("leftArrowPath")] 
		public CName LeftArrowPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("rightArrowPath")] 
		public CName RightArrowPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("label")] 
		public CWeakHandle<inkTextWidget> Label
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("value")] 
		public CWeakHandle<inkTextWidget> Value
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("leftArrow")] 
		public CWeakHandle<inkWidget> LeftArrow
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("rightArrow")] 
		public CWeakHandle<inkWidget> RightArrow
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("rightArrowButton")] 
		public CWeakHandle<inkButtonController> RightArrowButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(14)] 
		[RED("leftArrowButton")] 
		public CWeakHandle<inkButtonController> LeftArrowButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public inkSelectorController()
		{
			Index = -1;
			Values = new();
			CycledNavigation = true;
			SelectionChanged = new inkSelectionChangeCallback();
			LabelPath = "Panel/Label";
			ValuePath = "Panel/Value";
			LeftArrowPath = "Panel/LeftArrow";
			RightArrowPath = "Panel/RightArrow";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
