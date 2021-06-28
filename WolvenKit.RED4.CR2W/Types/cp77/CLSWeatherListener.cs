using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CLSWeatherListener : worldWeatherScriptListener
	{
		private wCHandle<CityLightSystem> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<CityLightSystem> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public CLSWeatherListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
