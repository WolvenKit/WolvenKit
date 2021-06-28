using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private ReflectorSFX _reflectorSFX;

		[Ordinal(108)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetProperty(ref _reflectorSFX);
			set => SetProperty(ref _reflectorSFX, value);
		}

		public BlindingLightControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
