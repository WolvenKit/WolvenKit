using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIResource : LibTreeCTreeResource
	{
		[Ordinal(2)] 
		[RED("root")] 
		public CHandle<AICTreeNodeDefinition> Root
		{
			get => GetPropertyValue<CHandle<AICTreeNodeDefinition>>();
			set => SetPropertyValue<CHandle<AICTreeNodeDefinition>>(value);
		}

		public AIResource()
		{
			Variables = new LibTreeDefTreeVariablesList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
