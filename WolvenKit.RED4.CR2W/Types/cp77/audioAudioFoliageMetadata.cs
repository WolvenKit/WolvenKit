using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioFoliageMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("loopStartEvent")] public CName LoopStartEvent { get; set; }
		[Ordinal(2)] [RED("loopStopEvent")] public CName LoopStopEvent { get; set; }
		[Ordinal(3)] [RED("locomotionTotalVelocityParam")] public CName LocomotionTotalVelocityParam { get; set; }
		[Ordinal(4)] [RED("locomotionTotalVelocityThreshold")] public CFloat LocomotionTotalVelocityThreshold { get; set; }
		[Ordinal(5)] [RED("locomotionAngularVelocityMultiplier")] public CFloat LocomotionAngularVelocityMultiplier { get; set; }
		[Ordinal(6)] [RED("minFoliageMeshVolumeThreshold")] public CFloat MinFoliageMeshVolumeThreshold { get; set; }
		[Ordinal(7)] [RED("maxFoliageMeshHeight")] public CFloat MaxFoliageMeshHeight { get; set; }
		[Ordinal(8)] [RED("playerInsideRequiredPercentage")] public CFloat PlayerInsideRequiredPercentage { get; set; }
		[Ordinal(9)] [RED("foliageMaterials")] public CHandle<audioAudioFoliageMaterialDictionary> FoliageMaterials { get; set; }

		public audioAudioFoliageMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
