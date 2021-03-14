using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightColorSettings : IAreaSettings
	{
		private worldWorldGlobalLightParameters _light;

		[Ordinal(2)] 
		[RED("light")] 
		public worldWorldGlobalLightParameters Light
		{
			get
			{
				if (_light == null)
				{
					_light = (worldWorldGlobalLightParameters) CR2WTypeManager.Create("worldWorldGlobalLightParameters", "light", cr2w, this);
				}
				return _light;
			}
			set
			{
				if (_light == value)
				{
					return;
				}
				_light = value;
				PropertySet(this);
			}
		}

		public LightColorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
