using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_6_ReplicatedVariables_SubStructure : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("exampleSubStructureVar")] 
		public CBool ExampleSubStructureVar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Ref_6_ReplicatedVariables_SubStructure()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
