using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LcdScreenILogicController : inkWidgetLogicController
	{
		private inkWidgetReference _defaultUI;
		private inkVideoWidgetReference _mainDisplayWidget;
		private inkTextWidgetReference _messegeWidget;
		private inkImageWidgetReference _backgroundWidget;
		private CWeakHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(1)] 
		[RED("defaultUI")] 
		public inkWidgetReference DefaultUI
		{
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(2)] 
		[RED("mainDisplayWidget")] 
		public inkVideoWidgetReference MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(3)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(4)] 
		[RED("backgroundWidget")] 
		public inkImageWidgetReference BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}

		[Ordinal(5)] 
		[RED("messegeRecord")] 
		public CWeakHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get => GetProperty(ref _messegeRecord);
			set => SetProperty(ref _messegeRecord, value);
		}

		[Ordinal(6)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(7)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}
	}
}
