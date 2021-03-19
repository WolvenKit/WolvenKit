using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKLegsData : CVariable
	{
		private CFloat _min_rel_offset;
		private CFloat _max_rel_offset;
		private CFloat _min_trace_offset;
		private CFloat _max_trace_offset;
		private CFloat _verticalOffsetBlendUpTime;
		private CFloat _verticalOffsetBlendDownTime;
		private CFloat _max_distance_for_trace_update;
		private CFloat _max_angle_from_upright_normal;
		private CFloat _max_angle_from_upright_normal_to_side;
		private CFloat _max_angle_from_upright_normal_to_revert_orientation;

		[Ordinal(0)] 
		[RED("Min rel offset")] 
		public CFloat Min_rel_offset
		{
			get => GetProperty(ref _min_rel_offset);
			set => SetProperty(ref _min_rel_offset, value);
		}

		[Ordinal(1)] 
		[RED("Max rel offset")] 
		public CFloat Max_rel_offset
		{
			get => GetProperty(ref _max_rel_offset);
			set => SetProperty(ref _max_rel_offset, value);
		}

		[Ordinal(2)] 
		[RED("Min trace offset")] 
		public CFloat Min_trace_offset
		{
			get => GetProperty(ref _min_trace_offset);
			set => SetProperty(ref _min_trace_offset, value);
		}

		[Ordinal(3)] 
		[RED("Max trace offset")] 
		public CFloat Max_trace_offset
		{
			get => GetProperty(ref _max_trace_offset);
			set => SetProperty(ref _max_trace_offset, value);
		}

		[Ordinal(4)] 
		[RED("verticalOffsetBlendUpTime")] 
		public CFloat VerticalOffsetBlendUpTime
		{
			get => GetProperty(ref _verticalOffsetBlendUpTime);
			set => SetProperty(ref _verticalOffsetBlendUpTime, value);
		}

		[Ordinal(5)] 
		[RED("verticalOffsetBlendDownTime")] 
		public CFloat VerticalOffsetBlendDownTime
		{
			get => GetProperty(ref _verticalOffsetBlendDownTime);
			set => SetProperty(ref _verticalOffsetBlendDownTime, value);
		}

		[Ordinal(6)] 
		[RED("Max distance for trace update")] 
		public CFloat Max_distance_for_trace_update
		{
			get => GetProperty(ref _max_distance_for_trace_update);
			set => SetProperty(ref _max_distance_for_trace_update, value);
		}

		[Ordinal(7)] 
		[RED("Max angle from upright normal")] 
		public CFloat Max_angle_from_upright_normal
		{
			get => GetProperty(ref _max_angle_from_upright_normal);
			set => SetProperty(ref _max_angle_from_upright_normal, value);
		}

		[Ordinal(8)] 
		[RED("Max angle from upright normal to side")] 
		public CFloat Max_angle_from_upright_normal_to_side
		{
			get => GetProperty(ref _max_angle_from_upright_normal_to_side);
			set => SetProperty(ref _max_angle_from_upright_normal_to_side, value);
		}

		[Ordinal(9)] 
		[RED("Max angle from upright normal to revert orientation")] 
		public CFloat Max_angle_from_upright_normal_to_revert_orientation
		{
			get => GetProperty(ref _max_angle_from_upright_normal_to_revert_orientation);
			set => SetProperty(ref _max_angle_from_upright_normal_to_revert_orientation, value);
		}

		public animSBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
