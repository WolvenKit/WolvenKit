using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("caption")] 
		public CString Caption
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("captionParts")] 
		public gameinteractionsChoiceCaption CaptionParts
		{
			get => GetPropertyValue<gameinteractionsChoiceCaption>();
			set => SetPropertyValue<gameinteractionsChoiceCaption>(value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CArray<CVariant> Data
		{
			get => GetPropertyValue<CArray<CVariant>>();
			set => SetPropertyValue<CArray<CVariant>>(value);
		}

		[Ordinal(3)] 
		[RED("choiceMetaData")] 
		public gameinteractionsChoiceMetaData ChoiceMetaData
		{
			get => GetPropertyValue<gameinteractionsChoiceMetaData>();
			set => SetPropertyValue<gameinteractionsChoiceMetaData>(value);
		}

		[Ordinal(4)] 
		[RED("lookAtDescriptor")] 
		public gameinteractionsChoiceLookAtDescriptor LookAtDescriptor
		{
			get => GetPropertyValue<gameinteractionsChoiceLookAtDescriptor>();
			set => SetPropertyValue<gameinteractionsChoiceLookAtDescriptor>(value);
		}

		public gameinteractionsChoice()
		{
			CaptionParts = new() { Parts = new() };
			Data = new();
			ChoiceMetaData = new() { Type = new() };
			LookAtDescriptor = new() { Offset = new(), OrbId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
