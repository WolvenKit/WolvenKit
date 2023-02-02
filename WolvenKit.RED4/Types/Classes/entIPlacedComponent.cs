using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entIPlacedComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("localTransform")] 
		public WorldTransform LocalTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(4)] 
		[RED("parentTransform")] 
		public CHandle<entITransformBinding> ParentTransform
		{
			get => GetPropertyValue<CHandle<entITransformBinding>>();
			set => SetPropertyValue<CHandle<entITransformBinding>>(value);
		}

		public entIPlacedComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
