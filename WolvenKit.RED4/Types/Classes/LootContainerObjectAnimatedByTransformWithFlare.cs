using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootContainerObjectAnimatedByTransformWithFlare : LootContainerObjectAnimatedByTransform
	{
		[Ordinal(50)] 
		[RED("colliderWithInteraction")] 
		public CHandle<entIComponent> ColliderWithInteraction
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(51)] 
		[RED("colliderWithoutInteraction")] 
		public CHandle<entIComponent> ColliderWithoutInteraction
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("lightComponent1")] 
		public CHandle<entIComponent> LightComponent1
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(53)] 
		[RED("lightComponent2")] 
		public CHandle<entIComponent> LightComponent2
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		public LootContainerObjectAnimatedByTransformWithFlare()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
