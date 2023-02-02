using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractionChoiceCaptionQuickhackCostPart : gameinteractionsChoiceCaptionScriptPart
	{
		[Ordinal(0)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public InteractionChoiceCaptionQuickhackCostPart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
