using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsVisibleTargetPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
