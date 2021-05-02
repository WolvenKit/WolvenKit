using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldLightingConfig : CVariable
	{
		private CFloat _lightAttenuationClamp;

		[Ordinal(0)] 
		[RED("lightAttenuationClamp")] 
		public CFloat LightAttenuationClamp
		{
			get => GetProperty(ref _lightAttenuationClamp);
			set => SetProperty(ref _lightAttenuationClamp, value);
		}

		public WorldLightingConfig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
