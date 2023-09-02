using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
	public partial class forklift : InteractiveDevice
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
	{
		[Ordinal(94)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_ForkliftDevice> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_ForkliftDevice>>();
			set => SetPropertyValue<CHandle<AnimFeature_ForkliftDevice>>(value);
		}

		[Ordinal(95)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("isPlayerUnder")] 
		public CBool IsPlayerUnder
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
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
