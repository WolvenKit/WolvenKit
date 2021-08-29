using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionChoiceCaptionQuickhackCostPart : gameinteractionsChoiceCaptionScriptPart
	{
		private CInt32 _cost;

		[Ordinal(0)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetProperty(ref _cost);
			set => SetProperty(ref _cost, value);
		}
	}
}
