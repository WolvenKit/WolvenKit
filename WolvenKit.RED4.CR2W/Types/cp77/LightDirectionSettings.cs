using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightDirectionSettings : IAreaSettings
	{
		private GlobalLightingTrajectoryOverride _direction;

		[Ordinal(2)] 
		[RED("direction")] 
		public GlobalLightingTrajectoryOverride Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (GlobalLightingTrajectoryOverride) CR2WTypeManager.Create("GlobalLightingTrajectoryOverride", "direction", cr2w, this);
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

		public LightDirectionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
