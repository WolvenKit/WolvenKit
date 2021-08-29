using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceCaption : RedBaseClass
	{
		private CArray<CHandle<gameinteractionsChoiceCaptionPart>> _parts;

		[Ordinal(0)] 
		[RED("parts")] 
		public CArray<CHandle<gameinteractionsChoiceCaptionPart>> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}
	}
}
