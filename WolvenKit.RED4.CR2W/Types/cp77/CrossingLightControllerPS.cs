using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightControllerPS : TrafficLightControllerPS
	{
		private CrossingLightSetup _crossingLightSFXSetup;

		[Ordinal(103)] 
		[RED("crossingLightSFXSetup")] 
		public CrossingLightSetup CrossingLightSFXSetup
		{
			get => GetProperty(ref _crossingLightSFXSetup);
			set => SetProperty(ref _crossingLightSFXSetup, value);
		}

		public CrossingLightControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
