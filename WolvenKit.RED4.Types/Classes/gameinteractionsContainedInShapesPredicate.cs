using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsContainedInShapesPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("useCameraPosition")] 
		public CBool UseCameraPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
