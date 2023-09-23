using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ImageSwappingController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ImageWidgetPath")] 
		public CString ImageWidgetPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("ButtonsPaths")] 
		public CArray<CName> ButtonsPaths
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("ButtonsNames")] 
		public CArray<CString> ButtonsNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(4)] 
		[RED("ButtonsValues")] 
		public CArray<CString> ButtonsValues
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(5)] 
		[RED("Buttons")] 
		public CArray<CWeakHandle<inkCanvasWidget>> Buttons
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkCanvasWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkCanvasWidget>>>(value);
		}

		public ImageSwappingController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
