using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AOEArea : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(94)] [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(95)] [RED("highLightActive")] public CBool HighLightActive { get; set; }
		[Ordinal(96)] [RED("visionBlockerComponent")] public CHandle<entIComponent> VisionBlockerComponent { get; set; }
		[Ordinal(97)] [RED("obstacleComponent")] public CHandle<gameinfluenceObstacleComponent> ObstacleComponent { get; set; }
		[Ordinal(98)] [RED("activeStatusEffects")] public CArray<wCHandle<gamedataStatusEffect_Record>> ActiveStatusEffects { get; set; }
		[Ordinal(99)] [RED("extendPercentAABB")] public CFloat ExtendPercentAABB { get; set; }
		[Ordinal(100)] [RED("isAABBExtended")] public CBool IsAABBExtended { get; set; }

		public AOEArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
