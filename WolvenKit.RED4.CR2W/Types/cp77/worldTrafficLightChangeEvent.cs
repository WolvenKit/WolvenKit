using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLightChangeEvent : redEvent
	{
		private CEnum<worldTrafficLightColor> _lightColor;

		[Ordinal(0)] 
		[RED("lightColor")] 
		public CEnum<worldTrafficLightColor> LightColor
		{
			get
			{
				if (_lightColor == null)
				{
					_lightColor = (CEnum<worldTrafficLightColor>) CR2WTypeManager.Create("worldTrafficLightColor", "lightColor", cr2w, this);
				}
				return _lightColor;
			}
			set
			{
				if (_lightColor == value)
				{
					return;
				}
				_lightColor = value;
				PropertySet(this);
			}
		}

		public worldTrafficLightChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
