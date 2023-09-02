using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSBehaviorConstraintNodeFloorIKVerticalBoneData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("Min offset")] 
		public CFloat Min_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("Max offset")] 
		public CFloat Max_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("offsetToDesiredBlendTime")] 
		public CFloat OffsetToDesiredBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("verticalOffsetBlendTime")] 
		public CFloat VerticalOffsetBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSBehaviorConstraintNodeFloorIKVerticalBoneData()
		{
			Bone = new animTransformIndex();
			Min_offset = -0.500000F;
			Max_offset = 0.500000F;
			OffsetToDesiredBlendTime = 0.100000F;
			Stiffness = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
