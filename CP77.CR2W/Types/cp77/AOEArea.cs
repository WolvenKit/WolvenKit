using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AOEArea : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("activeStatusEffects")] public CArray<wCHandle<gamedataStatusEffect_Record>> ActiveStatusEffects { get; set; }
		[Ordinal(1)]  [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(2)]  [RED("extendPercentAABB")] public CFloat ExtendPercentAABB { get; set; }
		[Ordinal(3)]  [RED("gameEffect")] public CHandle<gameEffectInstance> GameEffect { get; set; }
		[Ordinal(4)]  [RED("highLightActive")] public CBool HighLightActive { get; set; }
		[Ordinal(5)]  [RED("isAABBExtended")] public CBool IsAABBExtended { get; set; }
		[Ordinal(6)]  [RED("obstacleComponent")] public CHandle<gameinfluenceObstacleComponent> ObstacleComponent { get; set; }
		[Ordinal(7)]  [RED("visionBlockerComponent")] public CHandle<entIComponent> VisionBlockerComponent { get; set; }

		public AOEArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
