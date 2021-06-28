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
			get => GetProperty(ref _light);
			set => SetProperty(ref _light, value);
		}

		public LightColorSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
