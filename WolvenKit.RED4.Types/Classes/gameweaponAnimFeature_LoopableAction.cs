using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("loopDuration")] 
		public CFloat LoopDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("numLoops")] 
		public CUInt8 NumLoops
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameweaponAnimFeature_LoopableAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
