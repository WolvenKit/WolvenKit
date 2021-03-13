using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CLSWeatherListener : worldWeatherScriptListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<CityLightSystem> Owner { get; set; }

		public CLSWeatherListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
