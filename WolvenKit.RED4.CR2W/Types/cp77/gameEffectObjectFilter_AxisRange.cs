using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_AxisRange : gameEffectObjectSingleFilter
	{
		private CEnum<gameEffectObjectFilter_AxisRangeAxis> _axis;
		private gameEffectInputParameter_Vector _position;
		private gameEffectInputParameter_Vector _constraints;

		[Ordinal(0)] 
		[RED("axis")] 
		public CEnum<gameEffectObjectFilter_AxisRangeAxis> Axis
		{
			get
			{
				if (_axis == null)
				{
					_axis = (CEnum<gameEffectObjectFilter_AxisRangeAxis>) CR2WTypeManager.Create("gameEffectObjectFilter_AxisRangeAxis", "axis", cr2w, this);
				}
				return _axis;
			}
			set
			{
				if (_axis == value)
				{
					return;
				}
				_axis = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("position")] 
		public gameEffectInputParameter_Vector Position
		{
			get
			{
				if (_position == null)
				{
					_position = (gameEffectInputParameter_Vector) CR2WTypeManager.Create("gameEffectInputParameter_Vector", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("constraints")] 
		public gameEffectInputParameter_Vector Constraints
		{
			get
			{
				if (_constraints == null)
				{
					_constraints = (gameEffectInputParameter_Vector) CR2WTypeManager.Create("gameEffectInputParameter_Vector", "constraints", cr2w, this);
				}
				return _constraints;
			}
			set
			{
				if (_constraints == value)
				{
					return;
				}
				_constraints = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_AxisRange(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
