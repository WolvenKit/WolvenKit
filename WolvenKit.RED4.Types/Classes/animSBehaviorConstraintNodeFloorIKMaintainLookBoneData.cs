using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bone")] 
		public CName Bone
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("amountOfRotation")] 
		public CFloat AmountOfRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData()
		{
			AmountOfRotation = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
