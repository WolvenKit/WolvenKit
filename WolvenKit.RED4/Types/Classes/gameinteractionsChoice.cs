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

		[Ordinal(5)] 
		[RED("doNotTurnOffPreventionSystem")] 
		public CBool DoNotTurnOffPreventionSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsChoice()
		{
			CaptionParts = new gameinteractionsChoiceCaption { Parts = new() };
			Data = new();
			ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() };
			LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
