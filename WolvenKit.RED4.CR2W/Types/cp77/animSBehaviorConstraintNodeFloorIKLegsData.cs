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
			get
			{
				if (_min_rel_offset == null)
				{
					_min_rel_offset = (CFloat) CR2WTypeManager.Create("Float", "Min rel offset", cr2w, this);
				}
				return _min_rel_offset;
			}
			set
			{
				if (_min_rel_offset == value)
				{
					return;
				}
				_min_rel_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Max rel offset")] 
		public CFloat Max_rel_offset
		{
			get
			{
				if (_max_rel_offset == null)
				{
					_max_rel_offset = (CFloat) CR2WTypeManager.Create("Float", "Max rel offset", cr2w, this);
				}
				return _max_rel_offset;
			}
			set
			{
				if (_max_rel_offset == value)
				{
					return;
				}
				_max_rel_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Min trace offset")] 
		public CFloat Min_trace_offset
		{
			get
			{
				if (_min_trace_offset == null)
				{
					_min_trace_offset = (CFloat) CR2WTypeManager.Create("Float", "Min trace offset", cr2w, this);
				}
				return _min_trace_offset;
			}
			set
			{
				if (_min_trace_offset == value)
				{
					return;
				}
				_min_trace_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Max trace offset")] 
		public CFloat Max_trace_offset
		{
			get
			{
				if (_max_trace_offset == null)
				{
					_max_trace_offset = (CFloat) CR2WTypeManager.Create("Float", "Max trace offset", cr2w, this);
				}
				return _max_trace_offset;
			}
			set
			{
				if (_max_trace_offset == value)
				{
					return;
				}
				_max_trace_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("verticalOffsetBlendUpTime")] 
		public CFloat VerticalOffsetBlendUpTime
		{
			get
			{
				if (_verticalOffsetBlendUpTime == null)
				{
					_verticalOffsetBlendUpTime = (CFloat) CR2WTypeManager.Create("Float", "verticalOffsetBlendUpTime", cr2w, this);
				}
				return _verticalOffsetBlendUpTime;
			}
			set
			{
				if (_verticalOffsetBlendUpTime == value)
				{
					return;
				}
				_verticalOffsetBlendUpTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("verticalOffsetBlendDownTime")] 
		public CFloat VerticalOffsetBlendDownTime
		{
			get
			{
				if (_verticalOffsetBlendDownTime == null)
				{
					_verticalOffsetBlendDownTime = (CFloat) CR2WTypeManager.Create("Float", "verticalOffsetBlendDownTime", cr2w, this);
				}
				return _verticalOffsetBlendDownTime;
			}
			set
			{
				if (_verticalOffsetBlendDownTime == value)
				{
					return;
				}
				_verticalOffsetBlendDownTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Max distance for trace update")] 
		public CFloat Max_distance_for_trace_update
		{
			get
			{
				if (_max_distance_for_trace_update == null)
				{
					_max_distance_for_trace_update = (CFloat) CR2WTypeManager.Create("Float", "Max distance for trace update", cr2w, this);
				}
				return _max_distance_for_trace_update;
			}
			set
			{
				if (_max_distance_for_trace_update == value)
				{
					return;
				}
				_max_distance_for_trace_update = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Max angle from upright normal")] 
		public CFloat Max_angle_from_upright_normal
		{
			get
			{
				if (_max_angle_from_upright_normal == null)
				{
					_max_angle_from_upright_normal = (CFloat) CR2WTypeManager.Create("Float", "Max angle from upright normal", cr2w, this);
				}
				return _max_angle_from_upright_normal;
			}
			set
			{
				if (_max_angle_from_upright_normal == value)
				{
					return;
				}
				_max_angle_from_upright_normal = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("Max angle from upright normal to side")] 
		public CFloat Max_angle_from_upright_normal_to_side
		{
			get
			{
				if (_max_angle_from_upright_normal_to_side == null)
				{
					_max_angle_from_upright_normal_to_side = (CFloat) CR2WTypeManager.Create("Float", "Max angle from upright normal to side", cr2w, this);
				}
				return _max_angle_from_upright_normal_to_side;
			}
			set
			{
				if (_max_angle_from_upright_normal_to_side == value)
				{
					return;
				}
				_max_angle_from_upright_normal_to_side = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Max angle from upright normal to revert orientation")] 
		public CFloat Max_angle_from_upright_normal_to_revert_orientation
		{
			get
			{
				if (_max_angle_from_upright_normal_to_revert_orientation == null)
				{
					_max_angle_from_upright_normal_to_revert_orientation = (CFloat) CR2WTypeManager.Create("Float", "Max angle from upright normal to revert orientation", cr2w, this);
				}
				return _max_angle_from_upright_normal_to_revert_orientation;
			}
			set
			{
				if (_max_angle_from_upright_normal_to_revert_orientation == value)
				{
					return;
				}
				_max_angle_from_upright_normal_to_revert_orientation = value;
				PropertySet(this);
			}
		}

		public animSBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
