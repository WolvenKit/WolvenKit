using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootContainerAccessPointControllerPS : AccessPointControllerPS
	{
		[Ordinal(115)] 
		[RED("objRef")] 
		public NodeRef ObjRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public LootContainerAccessPointControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
