using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisInteractionChoiceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("rawInputKey")] 
		public CEnum<EInputKey> RawInputKey
		{
			get => GetPropertyValue<CEnum<EInputKey>>();
			set => SetPropertyValue<CEnum<EInputKey>>(value);
		}

		[Ordinal(2)] 
		[RED("isHoldAction")] 
		public CBool IsHoldAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get => GetPropertyValue<gameinteractionsChoiceTypeWrapper>();
			set => SetPropertyValue<gameinteractionsChoiceTypeWrapper>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get => GetPropertyValue<CArray<CVariant>>();
			set => SetPropertyValue<CArray<CVariant>>(value);
		}

		[Ordinal(6)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetPropertyValue<gameinteractionsChoiceCaption>();
			set => SetPropertyValue<gameinteractionsChoiceCaption>(value);
		}

		public gameinteractionsvisInteractionChoiceData()
		{
			Type = new();
			Data = new();
			CaptionParts = new() { Parts = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
