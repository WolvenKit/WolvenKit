using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisInteractionDisplayData : RedBaseClass
	{
		private CName _putAction;
		private CEnum<EInputKey> _wInputKey;
		private CBool _holdAction;
		private CString _calizedName;
		private gameinteractionsChoiceTypeWrapper _pe;
		private gameinteractionsChoice _oice;

		[Ordinal(0)] 
		[RED("putAction")] 
		public CName PutAction
		{
			get => GetProperty(ref _putAction);
			set => SetProperty(ref _putAction, value);
		}

		[Ordinal(1)] 
		[RED("wInputKey")] 
		public CEnum<EInputKey> WInputKey
		{
			get => GetProperty(ref _wInputKey);
			set => SetProperty(ref _wInputKey, value);
		}

		[Ordinal(2)] 
		[RED("HoldAction")] 
		public CBool HoldAction
		{
			get => GetProperty(ref _holdAction);
			set => SetProperty(ref _holdAction, value);
		}

		[Ordinal(3)] 
		[RED("calizedName")] 
		public CString CalizedName
		{
			get => GetProperty(ref _calizedName);
			set => SetProperty(ref _calizedName, value);
		}

		[Ordinal(4)] 
		[RED("pe")] 
		public gameinteractionsChoiceTypeWrapper Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(5)] 
		[RED("oice")] 
		public gameinteractionsChoice Oice
		{
			get => GetProperty(ref _oice);
			set => SetProperty(ref _oice, value);
		}
	}
}
