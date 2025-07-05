using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISharedVarTableDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("table")] 
		public CArray<AISharedVarDefinition> Table
		{
			get => GetPropertyValue<CArray<AISharedVarDefinition>>();
			set => SetPropertyValue<CArray<AISharedVarDefinition>>(value);
		}

		public AISharedVarTableDefinition()
		{
			Table = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
