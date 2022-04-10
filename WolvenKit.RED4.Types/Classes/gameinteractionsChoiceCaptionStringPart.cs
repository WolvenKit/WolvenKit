using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceCaptionStringPart : gameinteractionsChoiceCaptionPart
	{
		[Ordinal(0)] 
		[RED("content")] 
		public CString Content
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameinteractionsChoiceCaptionStringPart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
