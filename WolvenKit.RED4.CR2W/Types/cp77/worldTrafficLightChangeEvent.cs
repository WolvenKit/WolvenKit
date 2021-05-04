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
			get => GetProperty(ref _lightColor);
			set => SetProperty(ref _lightColor, value);
		}

		public worldTrafficLightChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
