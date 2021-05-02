using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlobalLightOverrideAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _color;
		private CFloat _lightAzimuth;
		private CFloat _lightElevation;

		[Ordinal(2)] 
		[RED("color")] 
		public curveData<HDRColor> Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(3)] 
		[RED("lightAzimuth")] 
		public CFloat LightAzimuth
		{
			get => GetProperty(ref _lightAzimuth);
			set => SetProperty(ref _lightAzimuth, value);
		}

		[Ordinal(4)] 
		[RED("lightElevation")] 
		public CFloat LightElevation
		{
			get => GetProperty(ref _lightElevation);
			set => SetProperty(ref _lightElevation, value);
		}

		public GlobalLightOverrideAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
