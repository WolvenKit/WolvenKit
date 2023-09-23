using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIGuardAreaSavedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("puppetId")] 
		public entEntityID PuppetId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public AIGuardAreaSavedData()
		{
			PuppetId = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
