using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeCMetanodeIfDefinition : LibTreeCMetanodeDefinition
	{
		[Ordinal(0)] 
		[RED("ifCondition")] 
		public LibTreeDefBool IfCondition
		{
			get => GetPropertyValue<LibTreeDefBool>();
			set => SetPropertyValue<LibTreeDefBool>(value);
		}

		[Ordinal(1)] 
		[RED("ifBranch")] 
		public CHandle<LibTreeINodeDefinition> IfBranch
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("elseBranch")] 
		public CHandle<LibTreeINodeDefinition> ElseBranch
		{
			get => GetPropertyValue<CHandle<LibTreeINodeDefinition>>();
			set => SetPropertyValue<CHandle<LibTreeINodeDefinition>>(value);
		}

		public LibTreeCMetanodeIfDefinition()
		{
			IfCondition = new LibTreeDefBool { VariableId = ushort.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
