using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SceneTierIIEvents : SceneTierAbstractEvents
	{
		[Ordinal(0)]  [RED("cachedSpeedValue")] public CFloat CachedSpeedValue { get; set; }
		[Ordinal(1)]  [RED("currentLocomotionState")] public CName CurrentLocomotionState { get; set; }
		[Ordinal(2)]  [RED("currentSpeedMovementPreset")] public CEnum<Tier2WalkType> CurrentSpeedMovementPreset { get; set; }
		[Ordinal(3)]  [RED("currentSpeedValue")] public CFloat CurrentSpeedValue { get; set; }
		[Ordinal(4)]  [RED("maxSpeedStat")] public CHandle<gameStatModifierData> MaxSpeedStat { get; set; }

		public SceneTierIIEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
