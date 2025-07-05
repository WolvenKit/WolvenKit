using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class forklift : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("reversed")] 
		public CBool Reversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(99)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_ForkliftDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_ForkliftDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_ForkliftDevice>>(value);
		}

		[Ordinal(100)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(101)] 
		[RED("isPlayerUnder")] 
		public CBool IsPlayerUnder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(102)] 
		[RED("cargoBox")] 
		public CHandle<entPhysicalMeshComponent> CargoBox
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		public forklift()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
