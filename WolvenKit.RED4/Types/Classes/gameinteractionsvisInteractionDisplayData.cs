using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisInteractionDisplayData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("putAction")] 
		public CName PutAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("wInputKey")] 
		public CEnum<EInputKey> WInputKey
		{
			get => GetPropertyValue<CEnum<EInputKey>>();
			set => SetPropertyValue<CEnum<EInputKey>>(value);
		}

		[Ordinal(2)] 
		[RED("HoldAction")] 
		public CBool HoldAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("calizedName")] 
		public CString CalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("pe")] 
		public gameinteractionsChoiceTypeWrapper Pe
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		[Ordinal(5)] 
		[RED("oice")] 
		public gameinteractionsChoice Oice
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		public gameinteractionsvisInteractionDisplayData()
		{
			Pe = new();
			Oice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
