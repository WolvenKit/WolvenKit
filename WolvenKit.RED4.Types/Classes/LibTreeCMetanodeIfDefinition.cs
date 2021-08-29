using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeCMetanodeIfDefinition : LibTreeCMetanodeDefinition
	{
		private LibTreeDefBool _ifCondition;
		private CHandle<LibTreeINodeDefinition> _ifBranch;
		private CHandle<LibTreeINodeDefinition> _elseBranch;

		[Ordinal(0)] 
		[RED("ifCondition")] 
		public LibTreeDefBool IfCondition
		{
			get => GetProperty(ref _ifCondition);
			set => SetProperty(ref _ifCondition, value);
		}

		[Ordinal(1)] 
		[RED("ifBranch")] 
		public CHandle<LibTreeINodeDefinition> IfBranch
		{
			get => GetProperty(ref _ifBranch);
			set => SetProperty(ref _ifBranch, value);
		}

		[Ordinal(2)] 
		[RED("elseBranch")] 
		public CHandle<LibTreeINodeDefinition> ElseBranch
		{
			get => GetProperty(ref _elseBranch);
			set => SetProperty(ref _elseBranch, value);
		}
	}
}
