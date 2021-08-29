using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsContainedInShapesPredicate : gameinteractionsIPredicateType
	{
		private CBool _useCameraPosition;

		[Ordinal(0)] 
		[RED("useCameraPosition")] 
		public CBool UseCameraPosition
		{
			get => GetProperty(ref _useCameraPosition);
			set => SetProperty(ref _useCameraPosition, value);
		}
	}
}
