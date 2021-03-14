using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _strength;
		private curveData<Vector4> _direction;

		[Ordinal(2)] 
		[RED("strength")] 
		public curveData<CFloat> Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public curveData<Vector4> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (curveData<Vector4>) CR2WTypeManager.Create("curveData:Vector4", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		public WindAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
