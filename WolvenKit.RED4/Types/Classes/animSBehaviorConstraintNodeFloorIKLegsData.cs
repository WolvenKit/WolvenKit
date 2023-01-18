using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSBehaviorConstraintNodeFloorIKLegsData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Min rel offset")] 
		public CFloat Min_rel_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Max rel offset")] 
		public CFloat Max_rel_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("Min trace offset")] 
		public CFloat Min_trace_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("Max trace offset")] 
		public CFloat Max_trace_offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("verticalOffsetBlendUpTime")] 
		public CFloat VerticalOffsetBlendUpTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("verticalOffsetBlendDownTime")] 
		public CFloat VerticalOffsetBlendDownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("Max distance for trace update")] 
		public CFloat Max_distance_for_trace_update
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("Max angle from upright normal")] 
		public CFloat Max_angle_from_upright_normal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("Max angle from upright normal to side")] 
		public CFloat Max_angle_from_upright_normal_to_side
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("Max angle from upright normal to revert orientation")] 
		public CFloat Max_angle_from_upright_normal_to_revert_orientation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSBehaviorConstraintNodeFloorIKLegsData()
		{
			Max_rel_offset = 0.500000F;
			Min_trace_offset = -1.000000F;
			Max_trace_offset = 1.000000F;
			VerticalOffsetBlendUpTime = 0.060000F;
			VerticalOffsetBlendDownTime = 0.030000F;
			Max_distance_for_trace_update = 0.020000F;
			Max_angle_from_upright_normal = 45.000000F;
			Max_angle_from_upright_normal_to_side = 180.000000F;
			Max_angle_from_upright_normal_to_revert_orientation = 70.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
