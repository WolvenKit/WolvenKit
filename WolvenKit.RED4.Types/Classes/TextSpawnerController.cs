using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TextSpawnerController : inkWidgetLogicController
	{
		private CInt32 _amountOfRows;
		private CName _lineTextWidgetID;
		private CArray<CWeakHandle<inkWidget>> _texts;

		[Ordinal(1)] 
		[RED("amountOfRows")] 
		public CInt32 AmountOfRows
		{
			get => GetProperty(ref _amountOfRows);
			set => SetProperty(ref _amountOfRows, value);
		}

		[Ordinal(2)] 
		[RED("lineTextWidgetID")] 
		public CName LineTextWidgetID
		{
			get => GetProperty(ref _lineTextWidgetID);
			set => SetProperty(ref _lineTextWidgetID, value);
		}

		[Ordinal(3)] 
		[RED("texts")] 
		public CArray<CWeakHandle<inkWidget>> Texts
		{
			get => GetProperty(ref _texts);
			set => SetProperty(ref _texts, value);
		}

		public TextSpawnerController()
		{
			_amountOfRows = 6;
		}
	}
}
