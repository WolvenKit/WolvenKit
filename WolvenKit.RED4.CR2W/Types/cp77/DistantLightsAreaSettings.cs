using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantLightsAreaSettings : IAreaSettings
	{
		private CFloat _distantLightStartDistance;
		private CFloat _distantLightFadeDistance;

		[Ordinal(2)] 
		[RED("distantLightStartDistance")] 
		public CFloat DistantLightStartDistance
		{
			get => GetProperty(ref _distantLightStartDistance);
			set => SetProperty(ref _distantLightStartDistance, value);
		}

		[Ordinal(3)] 
		[RED("distantLightFadeDistance")] 
		public CFloat DistantLightFadeDistance
		{
			get => GetProperty(ref _distantLightFadeDistance);
			set => SetProperty(ref _distantLightFadeDistance, value);
		}

		public DistantLightsAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
