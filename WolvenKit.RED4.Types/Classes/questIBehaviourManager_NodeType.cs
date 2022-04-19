using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questIBehaviourManager_NodeType : questIRetNodeType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questIBehaviourManager_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
