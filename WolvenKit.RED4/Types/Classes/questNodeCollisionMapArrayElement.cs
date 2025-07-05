using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questNodeCollisionMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("componentsCollisionMapArray")] 
		public CArray<questComponentCollisionMapArrayElement> ComponentsCollisionMapArray
		{
			get => GetPropertyValue<CArray<questComponentCollisionMapArrayElement>>();
			set => SetPropertyValue<CArray<questComponentCollisionMapArrayElement>>(value);
		}

		public questNodeCollisionMapArrayElement()
		{
			ComponentsCollisionMapArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
