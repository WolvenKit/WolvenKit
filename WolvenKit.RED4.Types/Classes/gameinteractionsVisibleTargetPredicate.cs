using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsVisibleTargetPredicate : gameinteractionsIPredicateType
	{
		private CBool _stopOnTransparent;

		[Ordinal(0)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetProperty(ref _stopOnTransparent);
			set => SetProperty(ref _stopOnTransparent, value);
		}
	}
}
