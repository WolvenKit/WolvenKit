using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalObstructionSettings : audioAudioMetadata
	{
		private CFloat _initialAbsorbtion;
		private CFloat _absorptionPerMeter;

		[Ordinal(1)] 
		[RED("initialAbsorbtion")] 
		public CFloat InitialAbsorbtion
		{
			get => GetProperty(ref _initialAbsorbtion);
			set => SetProperty(ref _initialAbsorbtion, value);
		}

		[Ordinal(2)] 
		[RED("absorptionPerMeter")] 
		public CFloat AbsorptionPerMeter
		{
			get => GetProperty(ref _absorptionPerMeter);
			set => SetProperty(ref _absorptionPerMeter, value);
		}

		public audioPhysicalObstructionSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
