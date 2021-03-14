using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayCameraData : IScriptable
	{
		private CFloat _is_forward_offset;
		private CFloat _upperbody_pitch_weight;
		private CFloat _forward_offset_value;
		private CFloat _upperbody_yaw_weight;
		private CFloat _is_pitch_off;
		private CFloat _is_yaw_off;

		[Ordinal(0)] 
		[RED("is_forward_offset")] 
		public CFloat Is_forward_offset
		{
			get
			{
				if (_is_forward_offset == null)
				{
					_is_forward_offset = (CFloat) CR2WTypeManager.Create("Float", "is_forward_offset", cr2w, this);
				}
				return _is_forward_offset;
			}
			set
			{
				if (_is_forward_offset == value)
				{
					return;
				}
				_is_forward_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("upperbody_pitch_weight")] 
		public CFloat Upperbody_pitch_weight
		{
			get
			{
				if (_upperbody_pitch_weight == null)
				{
					_upperbody_pitch_weight = (CFloat) CR2WTypeManager.Create("Float", "upperbody_pitch_weight", cr2w, this);
				}
				return _upperbody_pitch_weight;
			}
			set
			{
				if (_upperbody_pitch_weight == value)
				{
					return;
				}
				_upperbody_pitch_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forward_offset_value")] 
		public CFloat Forward_offset_value
		{
			get
			{
				if (_forward_offset_value == null)
				{
					_forward_offset_value = (CFloat) CR2WTypeManager.Create("Float", "forward_offset_value", cr2w, this);
				}
				return _forward_offset_value;
			}
			set
			{
				if (_forward_offset_value == value)
				{
					return;
				}
				_forward_offset_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("upperbody_yaw_weight")] 
		public CFloat Upperbody_yaw_weight
		{
			get
			{
				if (_upperbody_yaw_weight == null)
				{
					_upperbody_yaw_weight = (CFloat) CR2WTypeManager.Create("Float", "upperbody_yaw_weight", cr2w, this);
				}
				return _upperbody_yaw_weight;
			}
			set
			{
				if (_upperbody_yaw_weight == value)
				{
					return;
				}
				_upperbody_yaw_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("is_pitch_off")] 
		public CFloat Is_pitch_off
		{
			get
			{
				if (_is_pitch_off == null)
				{
					_is_pitch_off = (CFloat) CR2WTypeManager.Create("Float", "is_pitch_off", cr2w, this);
				}
				return _is_pitch_off;
			}
			set
			{
				if (_is_pitch_off == value)
				{
					return;
				}
				_is_pitch_off = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("is_yaw_off")] 
		public CFloat Is_yaw_off
		{
			get
			{
				if (_is_yaw_off == null)
				{
					_is_yaw_off = (CFloat) CR2WTypeManager.Create("Float", "is_yaw_off", cr2w, this);
				}
				return _is_yaw_off;
			}
			set
			{
				if (_is_yaw_off == value)
				{
					return;
				}
				_is_yaw_off = value;
				PropertySet(this);
			}
		}

		public GameplayCameraData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
