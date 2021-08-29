using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageSwappingController : inkWidgetLogicController
	{
		private CString _imageWidgetPath;
		private CArray<CName> _buttonsPaths;
		private CArray<CString> _buttonsNames;
		private CArray<CString> _buttonsValues;
		private CArray<CWeakHandle<inkCanvasWidget>> _buttons;

		[Ordinal(1)] 
		[RED("ImageWidgetPath")] 
		public CString ImageWidgetPath
		{
			get => GetProperty(ref _imageWidgetPath);
			set => SetProperty(ref _imageWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("ButtonsPaths")] 
		public CArray<CName> ButtonsPaths
		{
			get => GetProperty(ref _buttonsPaths);
			set => SetProperty(ref _buttonsPaths, value);
		}

		[Ordinal(3)] 
		[RED("ButtonsNames")] 
		public CArray<CString> ButtonsNames
		{
			get => GetProperty(ref _buttonsNames);
			set => SetProperty(ref _buttonsNames, value);
		}

		[Ordinal(4)] 
		[RED("ButtonsValues")] 
		public CArray<CString> ButtonsValues
		{
			get => GetProperty(ref _buttonsValues);
			set => SetProperty(ref _buttonsValues, value);
		}

		[Ordinal(5)] 
		[RED("Buttons")] 
		public CArray<CWeakHandle<inkCanvasWidget>> Buttons
		{
			get => GetProperty(ref _buttons);
			set => SetProperty(ref _buttons, value);
		}
	}
}
