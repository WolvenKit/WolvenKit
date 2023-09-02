using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVertexAnimationComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("vertexAnimationMapper")] 
		public entVertexAnimationMapper VertexAnimationMapper
		{
			get => GetPropertyValue<entVertexAnimationMapper>();
			set => SetPropertyValue<entVertexAnimationMapper>(value);
		}

		[Ordinal(4)] 
		[RED("animatedComponent")] 
		public CHandle<entISourceBinding> AnimatedComponent
		{
			get => GetPropertyValue<CHandle<entISourceBinding>>();
			set => SetPropertyValue<CHandle<entISourceBinding>>(value);
		}

		public entVertexAnimationComponent()
		{
			Name = "Component";
			VertexAnimationMapper = new entVertexAnimationMapper { Entries = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
