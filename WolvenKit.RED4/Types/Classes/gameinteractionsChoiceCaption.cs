using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceCaption : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parts")] 
		public CArray<CHandle<gameinteractionsChoiceCaptionPart>> Parts
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsChoiceCaptionPart>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsChoiceCaptionPart>>>(value);
		}

		public gameinteractionsChoiceCaption()
		{
			Parts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
