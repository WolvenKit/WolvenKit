using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questObjectDistance : questIDistance
	{
		[Ordinal(0)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("nodeRef2")] 
		public gameEntityReference NodeRef2
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questObjectDistance()
		{
			NodeRef2 = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
