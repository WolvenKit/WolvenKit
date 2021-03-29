using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class forklift : InteractiveDevice
	{
		private CHandle<AnimFeature_ForkliftDevice> _animFeature;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CBool _isPlayerUnder;
		private CHandle<entPhysicalMeshComponent> _cargoBox;

		[Ordinal(96)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_ForkliftDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(97)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(98)] 
		[RED("isPlayerUnder")] 
		public CBool IsPlayerUnder
		{
			get => GetProperty(ref _isPlayerUnder);
			set => SetProperty(ref _isPlayerUnder, value);
		}

		[Ordinal(99)] 
		[RED("cargoBox")] 
		public CHandle<entPhysicalMeshComponent> CargoBox
		{
			get => GetProperty(ref _cargoBox);
			set => SetProperty(ref _cargoBox, value);
		}

		public forklift(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
