using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAmbientSoundEmitterComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(1)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(2)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(3)]  [RED("repositionEnabled")] public CBool RepositionEnabled { get; set; }
		[Ordinal(4)]  [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }

		public entAmbientSoundEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
